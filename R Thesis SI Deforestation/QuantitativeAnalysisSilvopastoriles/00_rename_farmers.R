##Changing Columnnames of Farmers.dataframe
getwd()
#Load Farmers.df _______________
load("Dataframes/farmers.df.Rda")

#Rename Colnames of Farmers.df___________

colnames(farmers.df) <- c(
    "id_house",
    "f1_name",
    "f1_latitud",
    "f1_longitud",
    "f1_landscape",
    "f1_area_total",
    "f1_area_permanent_cultures",
    "f1_area_temporal_cultures",
    "f1_area_pasture_wo_sps"   ,   #without silvopastoral systems
    "f1_area_garden_yard_plot",
    "f1_area_fallow",             #descanso rastrojo
    "f1_area_sps", #without pasto de corte or banco forrajero
    "f1_area_agroforestry",#ríos, quebradas
    "f1_area_not_cultivable", 
    "f1_area_forest",
    "f1_area_wetlands",
    "f1_area_palms", #cananguachales or aguajales
    "f1_number_of_watersources",
    "f1_area_others",
    "f1_others_specified",
    "f1_area_others",
    "silvopastoral",
    "calves_f",
    "calves_m",
    "bulls",
    "cows_in_production",
    "cows_dry",
    "cows_pregnant",
    "tlu"
)
# Save Farmers.df _____________________
save(farmers.df, file = "Dataframes/farmers.df.Rda")
