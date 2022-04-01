load("Dataframes/livestock_na.omit.df.rda")
load("Dataframes/total_work_days_livestock.df.rda")

x <- merge(livestock_na.omit.df, total_work.df, by.x = "id_house", by.y = "id_house")
plot(x$area_total, x$animal_units)

x$yearly_work_per_hectare <- x$sum_total_work/(x$area_pasture_wo_sps+x$area_sps)

hist(x$yearly_work_per_hectare)


summary(lm(stocking_rate_pasture_silvo~yearly_work_per_hectare, data = x))


summary(glm(silvopastoral~yearly_work_per_hectare, family = binomial(link="probit"), data = x))

t.test(
  x=x$yearly_work_per_hectare[x$silvopastoral==FALSE],
  y=x$yearly_work_per_hectare[x$silvopastoral==TRUE]
)


hist(x$yearly_work_per_hectare[x$silvopastoral==FALSE], breaks = 100)
hist(x$yearly_work_per_hectare[x$silvopastoral==TRUE], breaks = 100)
