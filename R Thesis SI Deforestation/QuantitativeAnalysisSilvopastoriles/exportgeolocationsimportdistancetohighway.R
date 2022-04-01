load("Dataframes/farm1.df.Rda")
load("Dataframes/farm2.df.Rda")
load("Dataframes/farm3.df.Rda")

farm1_geolocations.df <- data.frame(farm1.df$id_hous, farm1.df$number_of_farms, farm1.df$f1_name, 
                                 farm1.df$id_finca_1, farm1.df$f1_lat, farm1.df$f1_long)
save(farm1_geolocations, file="Dataframes/farm1_geolocations.df.Rda")
write.csv(farm1_geolocations.df, file = "Dataframes/farms1_geolocations.df.csv")

farms_distance_to_highway <- data.frame(read.csv("Dataframes/farmsdistancetohighway.csv"))

farm1.df$distance_to_highway <- farms_distance_to_highway$Distance

farm_distance <- merge(farm1.df, farms_distance_to_highway, by.x = "id_house", by.y = "InputID", all.x = TRUE, all.y = FALSE)

farm1.df <- farm_distance
save(farm1.df, file="Dataframes/farm1.df.Rda")
