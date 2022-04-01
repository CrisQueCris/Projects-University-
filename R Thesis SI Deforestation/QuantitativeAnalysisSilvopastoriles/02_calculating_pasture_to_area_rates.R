#Load farmers.df___________
load("Dataframes/farmers.df.Rda")

# Calculate the Rates of Pastures to Totalland___________
farmers.df$pasture_to_area_total <- farmers.df$f1_area_pasture_wo_sps /
                              farmers.df$f1_area_total

# Calculate Rates of Pasture and Silvopasture to Totalland___________
farmers.df$pasture_sps_to_area_total <- (farmers.df$f1_area_pasture_wo_sps + 
                                         farmers.df$f1_area_sps) / 
                                        farmers.df$f1_area_total

#Calculate Rates of Forest to Totalland

farmers.df$forest_to_area_total <- farmers.df$f1_area_forest / 
                                    farmers.df$f1_area_total

#Calculate Rates of Pasture and Silvopasture to Forest

farmers.df$pasture_to_forest <- (farmers.df$f1_area_pasture_wo_sps + 
                              farmers.df$f1_area_sps)/farmers.df$f1_area_forest

#Calculate Rates of Forest to Pasture and Silvopasture

farmers.df$forest_to_pasture <- farmers.df$f1_area_forest/
  (farmers.df$f1_area_pasture_wo_sps + farmers.df$f1_area_sps)

#Save farmers.df___________________
save(farmers.df, file="Dataframes/farmers.df.Rda")

