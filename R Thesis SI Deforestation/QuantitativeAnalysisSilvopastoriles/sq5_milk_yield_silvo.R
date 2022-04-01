load("Dataframes/milk.df.rda")
load("Dataframes/farmers.df.rda")
milk.df$selfsufficiency <- milk.df$autoconsume/milk.df$sale 

farmers_milk.df <- merge(farmers.df, milk.df, by = "id_house")


farmers_milk.df$yield_hectare <- farmers_milk.df$anual_milk_production/
  (farmers_milk.df$f1_area_pasture_wo_sps+farmers_milk.df$f1_area_sps)

#correlation between yield per hectare and silvopastoral?
farmers_milk_na.omit.df <- data.frame(farmers_milk.df$id_house,
                                   farmers_milk.df$silvopastoral,
                                   farmers_milk.df$yield_hectare
                                   )



farmers_milk_na.omit.df <-  farmers_milk_na.omit.df[is.finite(farmers_milk_na.omit.df[,3]),]
farmers_milk_na.omit.df <- na.omit(farmers_milk_na.omit.df)
summary(farmers_milk_na.omit.df)

t.test(x=farmers_milk_na.omit.df$farmers_milk.df.yield_hectare[farmers_milk_na.omit.df$farmers_milk.df.silvopastoral==FALSE],
       y=farmers_milk_na.omit.df$farmers_milk.df.yield_hectare[farmers_milk_na.omit.df$farmers_milk.df.silvopastoral==TRUE]
       )

summary(glm(farmers_milk_na.omit.df$farmers_milk.df.silvopastoral
            ~farmers_milk_na.omit.df$farmers_milk.df.yield_hectare,
            family = binomial(probit)))

