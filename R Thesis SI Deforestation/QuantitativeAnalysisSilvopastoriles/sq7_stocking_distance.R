#SQ7: Does distance to markets determine the stocking rate of farmers?

#H7: Stocking rates fall with distance to markets. 


load("Dataframes/livestock_na.omit.df.rda")
#Linear Regression
stock_distance_lm <- lm(livestock_na.omit.df$stocking_rate_pasture_silvo
           ~livestock_na.omit.df$distance_to_highway)

summary(stock_distance_lm)

plot(livestock_na.omit.df$stocking_rate_pasture_silvo,
     livestock_na.omit.df$distance_to_highway)
abline(stock_distance_lm[[1]])
