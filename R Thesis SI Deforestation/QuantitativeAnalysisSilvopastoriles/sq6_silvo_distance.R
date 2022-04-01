#SQ6: Does distance to markets determine the probability of silvopastoral farming?
  
#H6:  The closer farms are to the national highway the more probable is that they 
#have silvopastoral systems.

load("Dataframes/livestock_na.omit.df.rda")
#Logit Model
summary(glm(livestock_na.omit.df$silvopastoral~livestock_na.omit.df$distance_to_highway,
            family = binomial(link="logit")))


#Probit Model      
summary(glm(livestock_na.omit.df$silvopastoral~livestock_na.omit.df$distance_to_highway,
            family = binomial(link="probit")))  
