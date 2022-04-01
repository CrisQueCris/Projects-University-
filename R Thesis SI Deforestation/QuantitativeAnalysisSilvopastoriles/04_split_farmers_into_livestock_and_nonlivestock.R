
# split farmers into livestock producers and non-livestock producers
load("Dataframes/farmers.df.Rda")

farmers.df$milkproduction <-   ifelse(
  farmers.df$purpose_milk=="No lleva a cabo la actividad", FALSE, TRUE)

farmers.df$meatproduction <- ifelse(
  farmers.df$purpose_meat =="No lleva a cabo la actividad", FALSE, TRUE)

farmers.df$livestockproduction <- ifelse(
  farmers.df$milkproduction==TRUE | farmers.df$meatproduction==TRUE, TRUE, FALSE)

farmers.df$double_purpose <- ifelse(
  farmers.df$milkproduction==TRUE & farmers.df$meatproduction==TRUE, TRUE, FALSE)


save(farmers.df, file="Dataframes/farmers.df.Rda")

