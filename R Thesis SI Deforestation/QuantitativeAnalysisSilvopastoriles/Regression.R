library(tidyverse)

load("Dataframes/farmers.df.Rda")
load("Dataframes/farm1.df.Rda")


##Build dataframe for regression

regression.df <- data.frame("id_house"=farmers.df$id_house,
                              "animal_units"=farmers.df$tlu, 
                              "area_total"=farmers.df$f1_area_total, 
                              "area_pasture_wo_sps"=farmers.df$f1_area_pasture_wo_sps,
                              "area_sps"=farmers.df$f1_area_sps,
                              "stocking_rate_total"=farmers.df$stocking_rate_total,
                              "stocking_rate_pasture"=farmers.df$stocking_rate_pasture,
                            "stocking_rate_pasture_silvo" =farmers.df$stocking_rate_pasture_silvo,
                              "silvopastoral"=farmers.df$silvopastoral,
                              "livestockproduction"=farmers.df$livestockproduction,
                              "pasture_to_area_total"=farmers.df$pasture_to_area_total,
                              "pasture_sps_to_area_total"= farmers.df$pasture_sps_to_area_total,
                              "forest_to_area_total"=farmers.df$forest_to_area_total,
                              "forest_to_pasture"=farmers.df$forest_to_pasture,
                              "distance_to_highway"=farm1.df$Distance
                              )
save(regression.df, file="Dataframes/regression.df.Rda")

#Filter only livestock farmers with valid TLU
livestock.df <- filter(regression.df, livestockproduction==TRUE & animal_units!="NA")
summary(livestock.df)

save(livestock.df, file = "Dataframes/livestock.df.Rda")

summary(complete.cases(livestock.df))

livestock_na.omit.df <- complete.cases(livestock.df)

table(livestock.df$silvopastoral, useNA ="ifany" )

livestock_na.omit.df <- na.omit(livestock.df)

summary(livestock_na.omit.df)

summary(livestock_na.omit.df)
save(livestock_na.omit.df, file = "Dataframes/livestock_na.omit.df.rda")





#Linear Regression model of Silvopastoral to Stocking_rate_total___________
summary(lm(stocking_rate_total ~ silvopastoral, data = deforest_livestock_na.omit.df))
summary(lm(stocking_rate_pasture ~ silvopastoral, data = deforest_livestock_na.omit.df))

#Linear Regression model of Forest Area to Total Area and the Stocking Rate on Total____________
Forest_to_Stocking.Model <- lm(stocking_rate_total ~ forest_to_area_total, data = deforest_livestock_na.omit.df, na.action = na.exclude)
plot(deforest_livestock_na.omit.df$stocking_rate_total, deforest_livestock_na.omit.df$forest_to_area_total)
plot(Forest_to_Stocking.Model)

print(Forest_to_Stocking.Model)

#Linear Regression model of Forest Area to Total Area and the Stocking Rate on Pasture____________
summary(lm(forest_to_area_total ~ stocking_rate_pasture, data = deforest_livestock_na.omit.df, na.action = "na.exclude"))


#Probit Model of Forest Area to Total Area and Silvopastoral
summary(glm(silvopastoral ~ forest_to_area_total, data = deforest_livestock_na.omit.df))

#Linear Regression model of   

summary(lm(stocking_rate_total ~ area_total, data = deforest_livestock_na.omit.df))
summary(lm(stocking_rate_pasture ~ area_pasture_wo_sps, data = deforest_livestock_na.omit.df))
summary(lm(stocking_rate_total ~ area_pasture_wo_sps, data = deforest_livestock_na.omit.df))
summary(lm(stocking_rate_pasture~tlu,deforest_livestock_na.omit.df))

# Mean Area of Sivopasture to Pasture of Silvopaturalfarmers
Silvopasture_to_pasture_mean <- mean(deforest_livestock_na.omit.df$area_sps[deforest_livestock_na.omit.df$silvopastoral==TRUE])/
mean(deforest_livestock_na.omit.df$area_pasture_wo_sps[deforest_livestock_na.omit.df$silvopastoral==TRUE])


#Dependence of distance to highway

summary(lm(stocking_rate_pasture ~ distance_to_highway, data = deforest_livestock_na.omit.df))
summary(lm(distance_to_highway ~ stocking_rate_pasture + silvopastoral, data = deforest_livestock_na.omit.df))
