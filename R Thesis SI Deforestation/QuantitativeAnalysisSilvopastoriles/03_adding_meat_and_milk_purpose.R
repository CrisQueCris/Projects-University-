### Adding Production Purpose to farmers.df


#Load Farmers.df__________
load("Dataframes/farmers.df.Rda")
load("Dataframes/farmers_production_purpose.df.Rda")

#Rename ActividadesProductivas change type

farmers_production_purpose.df <- as.data.frame(ActividadesProducitvasProposito_wide)

#Adding Milk and Meatproduction to farmers.df

farmers.df$purpose_milk <- farmers_production_purpose.df$`Ganadería (produccion de  leche)`
farmers.df$purpose_meat <- farmers_production_purpose.df$`Ganaderia (produccion de carne)`

#Saving farmers.df__________
save(farmers.df, file="Dataframes/farmers.df.Rda")
