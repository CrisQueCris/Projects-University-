load("Dataframes/si.df.rda")
load("db_final_r/forest.df.rda")

si.df <- merge(si.df, forest.df, by = "id_house")

save(si.df, file= "Dataframes/si.df.rda")
