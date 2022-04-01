library(readstata13)
library(tidyverse)
setwd("C:/Users/Lenovo/Dropbox/Studium/Master/Masterthesis/ZALF/DB_final")

load()
milk_production.df <- read.dta13("N_Ganaderia/Submodulos_long/N6_Productos_lacteos_long.dta")
summary(subset(milk_production.df, N11_1=="Leche"))
milk.df <- subset(milk_production.df, N11_1=="Leche")
milk.df <- data.frame(
  "id_house"=milk.df$ID_HOUSE,
  "milk_cows"=milk.df$N11_3,
  "daily_milk_production"=milk.df$N11_6,
  "anual_milk_production"=milk.df$N11_7,
  "unit_of_production"=milk.df$N11_7_1,
  "autoconsume"=milk.df$N11_8_1,
  "sale"=milk.df$N11_8_2,
  "price"=milk.df$N11_9_2,
  "sold"=milk.df$N11_9_3
)
summary(milk.df)       
milk.df <- filter(milk.df, !is.na(milk_cows))

milk.df$average_milk_production_per_day_per_cow <- 
  milk.df$daily_milk_production/
  milk.df$milk_cows
milk.df$average_milk_production_per_year_per_cow <- 
  milk.df$anual_milk_production/
  milk.df$milk_cows
summary(milk.df)

save(milk.df, file="0_SALDatabase/QuantitativeAnalysisSilvopastoriles/Dataframes/milk.df.rda")
