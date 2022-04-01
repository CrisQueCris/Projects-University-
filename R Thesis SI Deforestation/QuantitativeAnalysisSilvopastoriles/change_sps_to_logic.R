##Transfer Silvopastoral to Logic

load("Dataframes/farmers.df.Rda")

str(farmers.df$silvopastoral)

levels(farmers.df$silvopastoral) <- c(FALSE, TRUE)

farmers.df$silvopastoral <- as.logical(farmers.df$silvopastoral)

is.logical(farmers.df$silvopastoral)
summary(farmers.df$silvopastoral)


save(farmers.df, file="Dataframes/farmers.df.Rda")
