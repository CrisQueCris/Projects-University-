# SQ1: T-test 
load("Dataframes/livestock_na.omit.df.Rda")


summary(livestock_na.omit.df)
boxplot(livestock_na.omit.df$silvopastoral, livestock_na.omit.df$stocking_rate_pasture_silvo, names = c("conventional","silvopastoral"))

t.test(
  x=livestock_na.omit.df$stocking_rate_pasture_silvo[livestock_na.omit.df$silvopastoral==FALSE],
  y=livestock_na.omit.df$stocking_rate_pasture_silvo[livestock_na.omit.df$silvopastoral==TRUE],
  alternative = "less"
  )
