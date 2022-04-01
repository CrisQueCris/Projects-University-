getwd()
load("Dataframes/animals.df.Rda")
source("Functions/TransformFactorToLogical.r")



###Calculate Tropical Lifestock Units by multiplying calves by 0.5 and adult cows by 0.7 

Farmers$TLU <- rowSums(Farmers[,c(25:28)])*0.7 +  #adult cows
  Farmers$Terneras*0.5 +
  Farmers$Terneros*0.5 #calves
save(Farmers, file ="Dataframes/FarmersLandCattle.Rda")



TluCalculator <- function(exist, count, av_weight, tlu) 
  {
  tlu <- 1:341
  cat(tlu)
  exist.log <- TransformFactorToLogical(exist)
  cat(exist.log)
  for (i in tlu)
    {
    cat(i)
    if (is.na(exist.log[i])==TRUE) tlu[i] <- NA
      else
        if (exist.log[i]==FALSE) tlu[i] <- 0
          else tlu[i] <- (count * av_weight)/450
    }
    return(tlu)
  }

tlu_heifers <- TluCalculator(animals.df$heifers_bre_exist, animals.df$heifers_bre_count, animals.df$heifers_bre_average_weight)
warnings()
heifer <- data.frame(animals.df[,2:4], tlu_heifers)

