source("Functions/TransformFactorToLogical.r")

#Function takes logical value (exist: Si,no), Animal count, average weight and calcultes TLU 
#(1 TLU = 250kg average weight)
#Logic value is transformed into logic vector using TransfromFactorToLogical

CalculateTLU <- function(exist, count, av_weight, tlu) 
  {
  #cat("Si/no: ", exist, "\n", "Anzahl der Tiere: ", count, "\n", "Durchschnittliches Gewicht: ", av_weight, sep = ", ")
  tlu <- vector(mode = "integer", length = length(exist))
  #cat(tlu)
  exist.log <- TransformFactorToLogical(exist)
  #cat(exist.log)
  for (i in 1:length(tlu))
    {
    cat("i:", i, " ")
    if (is.na(exist.log[i])==TRUE) tlu[i] <- NA
      else
        if (exist.log[i]==FALSE) tlu[i] <- 0
          else tlu[i] <- (count[i] * av_weight[i])/450
    cat("\n", "Logical: ", exist.log[i], "count: ", count[i], "av_weight: ", av_weight[i], "TLU: ", tlu[i], "\n")
  }
  return(tlu)
  }

