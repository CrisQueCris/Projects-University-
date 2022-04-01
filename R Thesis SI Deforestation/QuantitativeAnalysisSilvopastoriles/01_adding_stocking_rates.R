# Stocking Rate
### Adding Stocking Rates to Farmers Dataframe


load("Dataframes/farmers.df.Rda")
load("Dataframes/animals.df.Rda")

farmers.df$tlu <- animals.df$TLU_total

## Calculating Stocking Rate from TLU and Total Land Size
farmers.df$stocking_rate_total <- farmers.df$tlu / farmers.df$f1_area_total

## Calculating Stocking Rate from TLU and Pasture Area.

farmers.df$stocking_rate_pasture <- farmers.df$tlu / farmers.df$f1_area_pasture_wo_sps

## Calculating Stocking Rate from TLU and Pasture Area plus Silvopastural Area 

farmers.df$stocking_rate_pasture_silvo <- farmers.df$tlu / (farmers.df$f1_area_pasture_wo_sps + 
                                                  farmers.df$f1_area_sps)




#save farmers.df ______________
save(farmers.df, file = "Dataframes/farmers.df.Rda")

#plotting Stocking Rate in Pasture to Stocking Rate in Total
plot(farmers.df$stocking_rate_pasture, farmers.df$stocking_rate_total)

