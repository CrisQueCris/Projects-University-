#loading all dataframes
library(tidyverse)
load("Dataframes/livestock.df.rda")
load("Dataframes/livestock_na.omit.df.rda")
load("Dataframes/total_work_days_livestock.df.rda")
load("Dataframes/milk.df.rda")
load("Dataframes/farmers.df.rda")

load("Dataframes/farm1.df.Rda")
load("Dataframes/farm2.df.Rda")
load("Dataframes/farm3.df.Rda")

# farm1.df <- farm1.df[,c(1,2,5,6,7,23,25, 27,29,32)]
# farm2.df <- farm2.df[farm2.df$number_of_farms>=2,]
# farm2.df <- farm2.df[,c(1,2,5,6,7,23,25, 27,29)]
# 
# farm3.df <- farm3.df[farm3.df$number_of_farms>=3,]
# farm3.df <- farm3.df[,c(1,2,5,6,7,23,25, 27,29)]
# 
# for (i in 1:nrow(farm1.df)) {
#   print(i)
#   if (farm1.df[i,]$number_of_farms <= 1) {
#     area_total[i] <- farm1.df[i,]$f1_area_total 
#   }else { 
#     if (farm1.df[i,]$number_of_farms == 2){
#       area_total[i] <- farm1.df[i,]$f1_area_total + farm2.df[i,]$f2_area_total 
#     }else {
#       area_total[i] <- farm1.df[i,]$f1_area_total + 
#         farm2.df[i,]$f2_area_total + 
#         farm3.df[i,]$f3_area_total
#     }
#   }
# }
# area_total
# area_total <- farm1.df$f1_area_total+farm2.df$f2_area_total+farm3.df$f3_area_total
#merging livestock with total_work
summary(livestock.df)
summary(total_work.df)
ll.df <-  merge(livestock.df, total_work.df, by.x = "id_house", by.y = "id_house")
summary(ll.df)

#merging with milk 
summary(milk.df)
llm <- merge(ll.df, milk.df, by.x = "id_house", by.y = "id_house" )
summary(llm)
hist(llm$sum_total_work)

#merging with farm1, number of farms
intens.df <- merge( llm, filter(farm1.df[,c(1,2)], number_of_farms==1), by.x = "id_house", by.y = "id_house")
summary(intens.df)
intensification.df <- merge(intens.df, farmers.df[,c(1,3:5,15, 22, 23, 30, 33)], by="id_house")

#Rename columns
intensification.df <- plyr::rename(intensification.df, c(
  "f1_landscape"="land_type",
 "f1_area_forest"="area_forest",
  "anual_milk_production"="milk_yield",
  "stocking_rate_pasture_silvo"="stocking_rate",
  "sum_total_work"="labour",
  "silvopastoral"="SPS",
  "area_pasture_wo_sps"="area_pasture",
  "animal_units"="au",
  "distance_to_highway"="distance",
  "forest_to_area_total"="forest_reserves",
 "f1_latitud"="latitud",
 "f1_longitud"="longitud")
 
)
colnames(intensification.df)
#Adding labourperhectaer, milkperhectare, pfplabour, pfplivestock
intensification.df$labourperhectare <- 
  intensification.df$labour/(intensification.df$area_pasture+intensification.df$area_sps)


intensification.df$milkperhectare <-
  intensification.df$milk_yield/(intensification.df$area_pasture+intensification.df$area_sps)
#intensification.df$pfplabour <- intensification.df$milkperhectare/intensification.df$labourperhectare
#intensification.df$pfplivestock <- intensification.df$milkperhectare/intensification.df$stocking_rate
#intensification.df$tfp <- intensification.df$milkperhectare/
 # (intensification.df$labourperhectare*intensification.df$stocking_rate)

intensification.df$tlu <- NULL
#si.df <- intensification.df
save(intensification.df, file = "Dataframes/intensification.df.rda")


summary(intensification.df)
#Omit NA INF
#intensification.na.omit.df <- na.omit(intensification.df)
#intensification.na.omit.df <- intensification.na.omit.df[is.finite(intensification.na.omit.df[,4]),]
#intensification.na.omit.df <- intensification.na.omit.df[is.finite(intensification.na.omit.df[,15]),]
#intensification.na.omit.df <- intensification.na.omit.df[intensification.na.omit.df$land_type == "Lomerío (lomas, mesas y vallecitos",]
#summary(intensification.na.omit.df)
#save(si.df, file = "Dataframes/si.df.rda")
