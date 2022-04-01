#SQ3: Do farmers with higher stocking rates have more forest resources than farmers 
#with lower stocking rates?
#Hypothesis 3: Farmers with a higher stocking rate have also a higher ratio of 
#forestlands to their total land sizes.

load("Dataframes/livestock_na.omit.df.rda")
#Linear Regression model of Forest Area to Total Area and the Stocking Rate on Pasture____________

summary(lm(forest_to_area_total ~ stocking_rate_pasture_silvo, data = livestock_na.omit.df))


##Hypothesis 3 exepted: Higher stocking rate actually means relatively higher forestresources