## Remove useless columns from farmers.df
load("Dataframes/farmers.df.Rda")

farmers.df[,19:21] <- NULL

save(farmers.df, file="Dataframes/farmers.df.Rda")
