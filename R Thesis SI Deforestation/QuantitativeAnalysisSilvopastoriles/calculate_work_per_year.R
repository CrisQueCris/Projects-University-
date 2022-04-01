#Calculate Work per year
library(tidyr)
library(tidyverse)
load("Dataframes/workforce_cattle.df.Rda")

summary(workforce_cattle.df)
#Summarize workhours


workforce_cattle.df <- filter(workforce_cattle.df, !is.na(livestock_activity))

levels(workforce_cattle.df$livestock_activity)
workforce_cattle.df[is.na(workforce_cattle.df)]<- 0

vaccination_application <- 
  filter(workforce_cattle.df, livestock_activity =="Aplicación de vacunas y antiparasitarios")
feeding_animals <- 
filter(workforce_cattle.df, livestock_activity =="Mano de obra para alimentar el ganado")
upkeep_of_meadows <- 
  filter(workforce_cattle.df, livestock_activity =="Mantenimiento de prados")
milking <- 
  filter(workforce_cattle.df, livestock_activity =="Ordeño de vacas")
other_specified <- 
filter(workforce_cattle.df, livestock_activity =="Otra (especifique)")                                          
cleaning_animal <-  
filter(workforce_cattle.df, livestock_activity =="Realización de aseo (Aplicación de sellante de pezón u otro)")
cleaning_stables <- 
filter(workforce_cattle.df, livestock_activity =="Limpiar las cocheras" )

work <- list(vaccination_application, feeding_animals, upkeep_of_meadows, 
             milking, cleaning_animal
             )

for (j in 1:5) {
      work[[j]]$total_family_work <- rowSums(work[[j]][,4:6])
      work[[j]]$total_contracted_work <- rowSums(work[[j]][,7:8])
    }



total_family_work <- 
    work[[1]]$total_family_work +
  work[[2]]$total_family_work +
  work[[3]]$total_family_work+
work[[4]]$total_family_work+
work[[5]]$total_family_work
summary(total_family_work)
hist(total_family_work, breaks = 2300)
total_contracted_work <- 
  work[[1]]$total_contracted_work +
  work[[2]]$total_contracted_work +
  work[[3]]$total_contracted_work+
  work[[4]]$total_contracted_work+
  work[[5]]$total_contracted_work
summary(total_contracted_work)
hist(total_contracted_work, breaks = 2300)
total_contracted_work

sum_total_work <- total_contracted_work+
  total_family_work
hist(sum_total_work, breaks = 2300)

total_work.df <- data.frame(
  "id_house" = work[[1]]$id_house,
  "total_family_work" = total_family_work,
  "total_contracted_work" = total_contracted_work,
  sum_total_work)
##Filter out "commercial"farmers that have contracted work unequal 0
nrow(filter(total_work.df, total_contracted_work==0))

save(total_work.df, file="Dataframes/total_work_days_livestock.df.rda")     
