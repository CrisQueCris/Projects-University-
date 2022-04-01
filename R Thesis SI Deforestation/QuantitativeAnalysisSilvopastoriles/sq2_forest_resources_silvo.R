#SQ2: Do farmers with silvopastoral systems have more forest resources than their 
#conventional counterparts?
#Hypothesis 2: Farmers with silvopastoral systems have a significantly higher 
#ratio of forestlands to total land size than farmers with conventional systems. 
load("Dataframes/livestock_na.omit.df.rda")




t.test(x=livestock_na.omit.df$forest_to_area_total[livestock_na.omit.df$silvopastoral==FALSE],
       y=livestock_na.omit.df$forest_to_area_total[livestock_na.omit.df$silvopastoral==TRUE],
       alternative = "less"
       )
#Hypothesis 2 rejected, 
#conventional farmers have much more forest resources than silvopastoral farmers