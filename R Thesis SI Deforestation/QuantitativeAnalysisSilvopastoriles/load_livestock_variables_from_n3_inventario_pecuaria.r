library(readstata13)
setwd("C:/Users/Lenovo/Dropbox/Studium/Master/Masterthesis/ZALF/DB_final")
N3_Inventario_pecuaria_wide <- read.dta13("N_Ganaderia/N_Ganaderia_wide.dta")



##Animales
id_house <- N3_Inventario_pecuaria_wide$ID_HOUSE

animals.df <- data.frame(id_house)

#Heifers breeding(Novillas Levante (1-2 años)) 
animals.df$heifers_bre_exist <- N3_Inventario_pecuaria_wide$N4_3_7 #          Tiene este tipo de animales?
animals.df$heifers_bre_count <- N3_Inventario_pecuaria_wide$N4_4_7 #          cuántos en total tenía en últimos 12meses?
animals.df$heifers_bre_average_weight <- N3_Inventario_pecuaria_wide$N4_6_7 # Cuál es el peso promedio del animal?  Kg

#Heifers bearing (Novillas Vientre (2-3 años))
animals.df$heifers_bea_exist <- N3_Inventario_pecuaria_wide$N4_3_8 #          Tiene este tipo de animales?
animals.df$heifers_bea_count <- N3_Inventario_pecuaria_wide$N4_4_8 #          cuántos en total tenía en últimos 12meses?
animals.df$heifers_bea_average_weight <- N3_Inventario_pecuaria_wide$N4_6_8 # Cuál es el peso promedio del animal?  Kg

#Young bulls for fattening (Novillos de Ceba Machos)
animals.df$bulls_fat_exist <- N3_Inventario_pecuaria_wide$N4_3_9 #          Tiene este tipo de animales?
animals.df$bulls_fat_count <- N3_Inventario_pecuaria_wide$N4_4_9 #          cuántos en total tenía en últimos 12meses?
animals.df$bulls_fat_average_weight <- N3_Inventario_pecuaria_wide$N4_6_9 # Cuál es el peso promedio del animal?  Kg


#Female Calves (Terneras (0-1 año))
animals.df$calves_f_exist <- N3_Inventario_pecuaria_wide$N4_3_13 #          Tiene este tipo de animales?
animals.df$calves_f_count <- N3_Inventario_pecuaria_wide$N4_4_13 #          cuántos en total tenía en últimos 12meses?
animals.df$calves_f_average_weight <- N3_Inventario_pecuaria_wide$N4_6_13 # Cuál es el peso promedio del animal?  Kg

#Male Calves (Terneros (0-1 año))
animals.df$calves_m_exist <- N3_Inventario_pecuaria_wide$N4_3_14 #          Tiene este tipo de animales?
animals.df$calves_m_count <- N3_Inventario_pecuaria_wide$N4_4_14 #          cuántos en total tenía en últimos 12meses?
animals.df$calves_m_average_weight <- N3_Inventario_pecuaria_wide$N4_6_14 # Cuál es el peso promedio del animal?  Kg

#Bulls older then 3 years (translation: Toros y Toretes)
animals.df$bulls_exist <- N3_Inventario_pecuaria_wide$N4_3_15 #          Tiene este tipo de animales?
animals.df$bulls_count <- N3_Inventario_pecuaria_wide$N4_4_15 #          cuántos en total tenía en últimos 12meses?
animals.df$bulls_average_weight <- N3_Inventario_pecuaria_wide$N4_6_15 # Cuál es el peso promedio del animal?  Kg

#Dry Cows (Vacas Horras/Secas/escoteras)
animals.df$cows_dry_exist <- N3_Inventario_pecuaria_wide$N4_3_16 #          Tiene este tipo de animales?
animals.df$cows_dry_count <- N3_Inventario_pecuaria_wide$N4_4_16 #          cuántos en total tenía en últimos 12meses?
animals.df$cows_dry_average_weight <- N3_Inventario_pecuaria_wide$N4_6_16 # Cuál es el peso promedio del animal?  Kg

#Pregnant Cows (Vacas Paridas (Aplica para sistemas de cría))
animals.df$cows_pregnant_exist <- N3_Inventario_pecuaria_wide$N4_3_17 #          Tiene este tipo de animales?
animals.df$cows_pregnant_count <- N3_Inventario_pecuaria_wide$N4_4_17 #          cuántos en total tenía en últimos 12meses?
animals.df$cows_pregnant_average_weight <- N3_Inventario_pecuaria_wide$N4_6_17 # Cuál es el peso promedio del animal?  Kg

#Cows is production (Vacas en Producción (En ordeño))
animals.df$cows_production_exist <- N3_Inventario_pecuaria_wide$N4_3_18 #          Tiene este tipo de animales?
animals.df$cows_production_count <- N3_Inventario_pecuaria_wide$N4_4_18 #          cuántos en total tenía en últimos 12meses?
animals.df$cows_production_average_weight <- N3_Inventario_pecuaria_wide$N4_6_18 # Cuál es el peso promedio del animal?  Kg




#save animals.df
save(animals.df, file = "0_SALDatabase/QuantitativeAnalysisSilvopastoriles/Dataframes/animals.df.Rda")


  
  
  
  
    


       
     
