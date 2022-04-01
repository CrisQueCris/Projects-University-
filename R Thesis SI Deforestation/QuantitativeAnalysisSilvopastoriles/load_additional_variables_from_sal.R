library(readstata13)
setwd("C:/Users/Lenovo/Dropbox/Studium/Master/Masterthesis/ZALF/DB_final")


household_data <- read.dta13("C_Datos_del_hogar/C_Datos_del_hogar_wide.dta")


id_house <- household_data$ID_HOUSE
always_lived_in_this_vereda <- household_data$C2 #C.2. ?Siempre han vivido usted y su familia en esta vereda?
time_in_this_vereda <- household_data$C2_1 #C.2.1. Si la respuesta es no, ?Hace cuantos a?os vive usted y su familia en la vereda?
household.df <- data.frame(id_house, always_lived_in_this_vereda, time_in_this_vereda)

save(household.df, file = "0_SALDatabase/QuantitativeAnalysisSilvopastoriles/Dataframes/household.df.rda")



dwelling <- read.dta13("D_Vivienda/D_Vivienda.dta")
id_house <- dwelling$ID_HOUSE
dwelling.df  <- data.frame(id_house)
#D.14. Via de acceso a la casa desde la cabecera municipal usada con mayor frecuencia [opci?n m?ltiple]
dwelling.df$house_road_access_mud_road <- dwelling$D14_1  #Camino de herradura
dwelling.df$house_road_access_river <- dwelling$D14_2  #R?o
dwelling.df$house_road_access_unpaved_road <- dwelling$D14_3 #Via sin pavimentar
dwelling.df$house_road_access_paved_road <- dwelling$D14_4 #Via pavimentada

dwelling.df$transport_house_to_municipality <- dwelling$D14_1_1 #D.14.1 #Medio de transporte usado con m?s frecuencia para ir desde la casa a la cabecera municipal [opci?n m?ltiple]
dwelling.df$motobike <- dwelling$D14_1_1_1 #Moto
dwelling.df$own_car <- dwelling$D14_1_1_2 #Carro particular
dwelling.df$walking <- dwelling$D14_1_1_3#Caminando
dwelling.df$horse <- dwelling$D14_1_1_4 #Caballo
dwelling.df$public_transport <- dwelling$D14_1_1_5 #Transporte p?blico
dwelling.df$canoe <- dwelling$D14_1_1_6 #Canoa
dwelling.df$other <- dwelling$D14_1_1_7#Otro (especificar)

save(dwelling.df, file = "0_SALDatabase/QuantitativeAnalysisSilvopastoriles/Dataframes/dwelling.df.rda")

Productive_activities_and_natural_resources <- read.dta13("H_Actividades_productivas_y_recursos_naturales/H1_Actividades_Productivas_long.dta")

id_house <- Productive_activities_and_natural_resources$ID_HOUSE
productive_activity.df <- data.frame(id_house)
productive_activity.df$productive_activity <- Productive_activities_and_natural_resources$H1 #Actividad productiva
productive_activity.df$activity_realized <- Productive_activities_and_natural_resources$H1_0#?Realiza la actividad?
productive_activity.df$purpose <- Productive_activities_and_natural_resources$H1_2#?Prop?sito?

save(productive_activity.df, file = "0_SALDatabase/QuantitativeAnalysisSilvopastoriles/Dataframes/productive_activity.df.rda")

natural_resources <- read.dta13("H_Actividades_productivas_y_recursos_naturales/H2_Recursos_Naturales_long.dta")
id_house <- natural_resources$ID_HOUSE
natural_resources.df <- data.frame(id_house)

natural_resources.df$activity_natural_resources <- natural_resources$H2_1	#Actividades relacionadas al uso de recursos naturales
natural_resources.df$activity_place_realized <- natural_resources$H2_2# ?Realiza la actividad?
natural_resources.df$forest <- natural_resources$H2_3_1# Bosque
natural_resources.df$stubbles <- natural_resources$H2_3_2# Rastrojo
natural_resources.df$cultures <- natural_resources$H2_3_3# ?rea de cultivos
natural_resources.df$homegarden <- natural_resources$H2_3_4# Huerta
natural_resources.df$pastures <- natural_resources$H2_3_5# ?rea de pasturas
natural_resources.df$other <- natural_resources$H2_3_6# Otros (especificar - por ej. cananguchal, silvopastoril, agroforestal)
natural_resources.df$others_specified <- natural_resources$H2_3_6A# Otros (especificar - por ej. cananguchal, silvopastoril, agroforestal) (2)

save(natural_resources.df, file = "0_SALDatabase/QuantitativeAnalysisSilvopastoriles/Dataframes/natural_resources.df.rda")

#Forest - Land Transformation
land_transformation <- read.dta13("H_Actividades_productivas_y_recursos_naturales/H3_Transformacion_de_terrenos_long.dta")
land_transformation.df <- data.frame("id_house" =land_transformation$ID_HOUSE,
                                       "question" = land_transformation$H6_1,	#H.6. Pregunta
                                     "hectares" = land_transformation$H6_1_1,#	H.6. Hectareas
                                     "kind_of_change" = land_transformation$H6_2	# H.6. Descripci?n del cambio
  )
save(land_transformation.df, file = "0_SALDatabase/QuantitativeAnalysisSilvopastoriles/Dataframes/land_transformation.df.rda")


#Deforestation
deforestation <- read.dta13("H_Actividades_productivas_y_recursos_naturales/H4_Fuentes_de_conflicto_y_reforestacion_long.dta")

deforestation.df <- data.frame("id_house" =deforestation$ID_HOUSE,
                                 "hectares_cut_since_installation_of_finca"=    deforestation$H3,	#H.3. ?Cu?ntas hect?reas de bosque tumb? desde la fecha de instalaci?n de la familia?
                                 "hectares_cut_since_2010"=deforestation$H3_1	,##H.3.1 ?Cu?ntas hect?reas de bosque tumb? desde el 2010 hasta el presente?
                    #    "reason_for_cutting"=deforestation$H3_2,#	H.3.2 ?Por qu? motivo decidi? tumbar el bosque? [opci?n m?ltiple]
                               "wood_to_sell"=deforestation$H3_2_1,	#Extracci?n de madera para la venta
                               "wood_for_domestic_use"=deforestation$H3_2_2,	#Extracci?n de madera para uso dom?stico
                               "wood_for_home_construction"=deforestation$H3_2_3,	#Extracci?n de madera para construir estructuras de la finca (corrales, establos, etc.)
                               "pasture_establishment"=deforestation$H3_2_4,	#Establecimiento de pasturas
                               "comercial_cultures_establishment"=deforestation$H3_2_5,	#Establecimiento de cultivos comerciales
                               "pan_coger_establishment"=deforestation$H3_2_6,	#Establecimiento de cultivos de pan coger
                               "coca_cultures_establishment"=deforestation$H3_2_7,#	establecimiento de cultivo de coca
                               "other_specify"=deforestation$H3_2_8,	#Otro (especificar)
                               "specified_other"=deforestation$H3_A	#H.3.2 ?Por qu? motivo decidi? tumbar el bosque? (Especifique)
)
save(deforestation.df, file="0_SALDatabase/QuantitativeAnalysisSilvopastoriles/Dataframes/deforestation.df.Rda")
                    

forest_conservation.df <- data.frame("id_house" =deforestation$ID_HOUSE,
                     #deforestation$H4,	#H.4. ?Si tiene bosque, para qu? lo conserva ? [opci?n m?ltiple]
                               "protection_of_watersource"=deforestation$H4_1,	#Para proteger la fuente de agua
                               "shadow_for_humans"=deforestation$H4_2,	#Para tener sombra/frescura (humanos)
                               "shadow_for_animals"=deforestation$H4_3,	#Para tener sombra/frescura (animales)
                               "hunting"=deforestation$H4_4,	#Para cazar
                               "fruit_colection"=deforestation$H4_5,	#Para colectar frutas
                               "subsidies"=deforestation$H4_6,	#Para captar subsidios
                               "monetary_reserve"=deforestation$H4_7,	#Para reserva de dinero (maderables, animales)
                               "construction_reserve"=deforestation$H4_8,	#Como reserva para la construcci?n
                               "environmental_protection"=deforestation$H4_9,	#Para proteger el medio ambiente
                               "heritage_for_children"=deforestation$H4_10,	#Para heredarlo a sus hijos/nietos
                               "other_reason"=deforestation$H4_11,	#Otros (especificar)
                               "other_reason_specified"=deforestation$H4A,	#H.4. ?Si tiene bosque, para qu? lo conserva ? (Especifique)
                               "reforested"=deforestation$H5_C1,#	?Ha reforestado su finca?
                                "hectares_reforested"= deforestation$H5	#H.5 ?Cu?ntas hect?reas reforest? desde el 2010 hasta el presente? [sin incluir palma aceitera, palmito y caucho]
)
save(forest_conservation.df, file="0_SALDatabase/QuantitativeAnalysisSilvopastoriles/Dataframes/forest_conservation.df.Rda")

reforestation.df <- data.frame("id_house" =deforestation$ID_HOUSE,
                     #deforestation$H5_2,	H.5.2. ?Por qu? reforest? su finca? [opci?n m?ltiple]
                               "governmental_reforestation_program"=deforestation$H5_2_1,	#Programa gubernamental de reforestaci?n
                               "non_governmental_reforestation_program"=deforestation$H5_2_2,	#Programa no gubernamental de reforestaci?n
                               "forest_plantation"=deforestation$H5_2_3,	#Para establecer plantaci?n forestal
                               "water_protection"=deforestation$H5_2_4,#	Para proteger el agua de la quebrada
                               "animal_health"=deforestation$H5_2_5,	#Para la salud de los animales
                               "pest_protection"=deforestation$H5_2_6,	#Para proteger los cultivos de diferentes plagas
                               "erosion_protection"=deforestation$H5_2_7,	#Para evitar la erosi?n del suelo
                               "shadow_creation"=deforestation$H5_2_8,	#Para brindar sombra
                               "protection_of_nature"=deforestation$H5_2_9,	#Para la conservaci?n de la naturaleza
                               "future_of_children"=deforestation$H5_2_10,	#Para el futuro de mis hijos
                               "other_reason_for_reforestation"=deforestation$H5_2_11,	#Otro (especificar)
                               "other_reforestation_reason_specified" =deforestation$H5_2A#	H.5.2. #?Por qu? reforest? su finca? (Especifique)
)
save(reforestation.df, file="0_SALDatabase/QuantitativeAnalysisSilvopastoriles/Dataframes/reforestation.df.Rda")

#Finca Modulo K. Caracterizaci?n de la finca


Characterizationfinca_wide <- read.dta13("K_Caracterizacion_de_la_finca/K_Caracterizacion_de_la_finca_wide.dta")
Characterizationfinca_long <- read.dta13("K_Caracterizacion_de_la_finca/Submodulos_long/K_Caracterizaci?n_de_la_finca_long.dta")

farm1.df <- data.frame("id_house" =Characterizationfinca_wide$ID_HOUSE,
                        "number_of_farms" = Characterizationfinca_wide$K_C0, #	340	K.1 ?Cu?ntas fincas tiene a su disposici?n para la explotaci?n agropecuaria y/o
                       "id_finca_1" = Characterizationfinca_wide$ID_FINCA_1,#	341	ID FINCA 1
"f1_name" = Characterizationfinca_wide$K1_1_1,#	340	Finca 1: Nombre
"f1_lat" = Characterizationfinca_wide$K1_1_1_1,#	339	c
"f1_long" = Characterizationfinca_wide$K1_1_2_1,#	339	Finca 1: Longitud
"f1_landscape" = Characterizationfinca_wide$K1_5_1,#	341	Finca 1: En qu? paisaje se encuentra
"f1_mountain" = Characterizationfinca_wide$K1_5_1_1,#	341	Finca 1: En qu? paisaje se encuentra: Cordillera-Monta?a
"f1_floodplain" = Characterizationfinca_wide$K1_5_2_1,#	341	Finca 1: En qu? paisaje se encuentra: Vega
"f1_mountainfood" = Characterizationfinca_wide$K1_5_3_1,#	341	Finca 1: En qu? paisaje se encuentra: Piedemonte
"f1_hills" = Characterizationfinca_wide$K1_5_4_1,#	341	Finca 1: En qu? paisaje se encuentra: Lomer?o (lomas, mesas y vallecitos)
"f1_other" = Characterizationfinca_wide$K1_5_5_1,#	341	Finca 1: En qu? paisaje se encuentra: Otro, ?cu?l?
"f1_living_on_farm" = Characterizationfinca_wide$J1_CVF_1,#	341	Finca 1: Vive en la finca
"f1_transport_method" = Characterizationfinca_wide$K1_6_1,#	56	Finca 1: Si no vive en la finca, cu?l es el m?todo de transporte usado con m?s f
"f1_motorbike" = Characterizationfinca_wide$K1_6_1_1,#	341	Finca 1: M?todo de transporte usado: Moto
"f1_own_car" = Characterizationfinca_wide$K1_6_2_1,#	341	Finca 1: M?todo de transporte usado: Carro particular
"f1_walking" = Characterizationfinca_wide$K1_6_3_1,#	341	Finca 1: M?todo de transporte usado: Caminando
"f1_horseback" = Characterizationfinca_wide$K1_6_4_1,#	341	Finca 1: M?todo de transporte usado: Caballo
"f1_public_transport" = Characterizationfinca_wide$K1_6_5_1,#	341	Finca 1: M?todo de transporte usado: transporte p?blico
"f1_canoe" = Characterizationfinca_wide$K1_6_6_1,#	341	Finca 1: M?todo de transporte usado: Canoa
"f1_other_transport" = Characterizationfinca_wide$K1_6_7_1,#	341	Finca 1: M?todo de transporte usado: Otro.?Cu?l?
  "f1_time_of_travel" = Characterizationfinca_wide$K1_7_1,#	57	Finca 1: Tiempo promedio requerido (Horas)
"f1_area_total" = Characterizationfinca_wide$K2_1_1,#	340	Finca 1: ?rea total de la finca
"f1_area_permanent_cultures" = Characterizationfinca_wide$K2_2_1,#	310	Finca 1: ?rea en cultivos permanentes  incluyendo pasto de corte o banco forraje
"f1_area_pasture_wo_sps" = Characterizationfinca_wide$K2_4_1,#	338	Finca 1: ?rea en pasturas  sin incluir las que estan en sistemas silvopastoriles
"f1_area_fallow" = Characterizationfinca_wide$K2_6_1,#	324	Finca 1: ?rea en descanso rastrojo
"f1_area_sps" = Characterizationfinca_wide$K2_7_1,#	309	Finca 1: Silvopastoril  sin incluir pasto de corte o banco forrajero
"f1_area_agroforestry" = Characterizationfinca_wide$K2_8_1,#	305	Finca 1: ?rea agroforestal
"f1_area_forest" = Characterizationfinca_wide$K2_10_1,#	323	Finca 1: ?rea en bosque
"soils_code" = Characterizationfinca_wide$COD_SUELOS#	24	COD_SUELOS
)
save(farm1.df, file="0_SALDatabase/QuantitativeAnalysisSilvopastoriles/Dataframes/farm1.df.Rda")

farm2.df <- data.frame("id_house" =Characterizationfinca_wide$ID_HOUSE,
                       "number_of_farms" = Characterizationfinca_wide$K_C0, #	340	K.1 ?Cu?ntas fincas tiene a su disposici?n para la explotaci?n agropecuaria y/o
                       "id_finca_1" = Characterizationfinca_wide$ID_FINCA_2,#	341	ID FINCA 1
                       "f2_name" = Characterizationfinca_wide$K1_1_2,#	340	Finca 1: Nombre
                       "f2_lat" = Characterizationfinca_wide$K1_1_1_2,#	339	Finca 1: Latitud
                       "f2_long" = Characterizationfinca_wide$K1_1_2_2,#	339	Finca 1: Longitud
                       "f2_landscape" = Characterizationfinca_wide$K1_5_2,#	341	Finca 1: En qu? paisaje se encuentra
                       "f2_mountain" = Characterizationfinca_wide$K1_5_1_2,#	341	Finca 1: En qu? paisaje se encuentra: Cordillera-Monta?a
                       "f2_floodplain" = Characterizationfinca_wide$K1_5_2_2,#	341	Finca 1: En qu? paisaje se encuentra: Vega
                       "f2_mountainfood" = Characterizationfinca_wide$K1_5_3_2,#	341	Finca 1: En qu? paisaje se encuentra: Piedemonte
                       "f2_hills" = Characterizationfinca_wide$K1_5_4_2,#	341	Finca 1: En qu? paisaje se encuentra: Lomer?o (lomas, mesas y vallecitos)
                       "f2_other" = Characterizationfinca_wide$K1_5_5_2,#	341	Finca 1: En qu? paisaje se encuentra: Otro, ?cu?l?
                       "f2_living_on_farm" = Characterizationfinca_wide$J1_CVF_2,#	341	Finca 1: Vive en la finca
                       "f2_transport_method" = Characterizationfinca_wide$K1_6_2,#	56	Finca 1: Si no vive en la finca, cu?l es el m?todo de transporte usado con m?s f
                       "f2_motorbike" = Characterizationfinca_wide$K1_6_1_2,#	341	Finca 1: M?todo de transporte usado: Moto
                       "f2_own_car" = Characterizationfinca_wide$K1_6_2_2,#	341	Finca 1: M?todo de transporte usado: Carro particular
                       "f2_walking" = Characterizationfinca_wide$K1_6_3_2,#	341	Finca 1: M?todo de transporte usado: Caminando
                       "f2_horseback" = Characterizationfinca_wide$K1_6_4_2,#	341	Finca 1: M?todo de transporte usado: Caballo
                       "f2_public_transport" = Characterizationfinca_wide$K1_6_5_2,#	341	Finca 1: M?todo de transporte usado: transporte p?blico
                       "f2_canoe" = Characterizationfinca_wide$K1_6_6_2,#	341	Finca 1: M?todo de transporte usado: Canoa
                       "f2_other_transport" = Characterizationfinca_wide$K1_6_7_2,#	341	Finca 1: M?todo de transporte usado: Otro.?Cu?l?
                       "f2_time_of_travel" = Characterizationfinca_wide$K1_7_2,#	57	Finca 1: Tiempo promedio requerido (Horas)
                       "f2_area_total" = Characterizationfinca_wide$K2_1_2,#	340	Finca 1: ?rea total de la finca
                       "f2_area_permanent_cultures" = Characterizationfinca_wide$K2_2_2,#	310	Finca 1: ?rea en cultivos permanentes  incluyendo pasto de corte o banco forraje
                       "f2_area_pasture_wo_sps" = Characterizationfinca_wide$K2_4_2,#	338	Finca 1: ?rea en pasturas  sin incluir las que estan en sistemas silvopastoriles
                       "f2_area_fallow" = Characterizationfinca_wide$K2_6_2,#	324	Finca 1: ?rea en descanso rastrojo
                       "f2_area_sps" = Characterizationfinca_wide$K2_7_2,#	309	Finca 1: Silvopastoril  sin incluir pasto de corte o banco forrajero
                       "f2_area_agroforestry" = Characterizationfinca_wide$K2_8_2,#	305	Finca 1: ?rea agroforestal
                       "f2_area_forest" = Characterizationfinca_wide$K2_10_2#	323	Finca 1: ?rea en bosque
)

save(farm2.df, file="0_SALDatabase/QuantitativeAnalysisSilvopastoriles/Dataframes/farm2.df.Rda")


farm3.df <- data.frame("id_house" =Characterizationfinca_wide$ID_HOUSE,
                       "number_of_farms" = Characterizationfinca_wide$K_C0, #	340	K.1 ?Cu?ntas fincas tiene a su disposici?n para la explotaci?n agropecuaria y/o
                       "id_finca_1" = Characterizationfinca_wide$ID_FINCA_3,#	341	ID FINCA 1
                       "f3_name" = Characterizationfinca_wide$K1_1_3,#	340	Finca 1: Nombre
                       "f3_lat" = Characterizationfinca_wide$K1_1_1_3,#	339	Finca 1: Latitud
                       "f3_long" = Characterizationfinca_wide$K1_1_2_3,#	339	Finca 1: Longitud
                       "f3_landscape" = Characterizationfinca_wide$K1_5_3,#	341	Finca 1: En qu? paisaje se encuentra
                       "f3_mountain" = Characterizationfinca_wide$K1_5_1_3,#	341	Finca 1: En qu? paisaje se encuentra: Cordillera-Monta?a
                       "f3_floodplain" = Characterizationfinca_wide$K1_5_2_3,#	341	Finca 1: En qu? paisaje se encuentra: Vega
                       "f3_mountainfood" = Characterizationfinca_wide$K1_5_3_3,#	341	Finca 1: En qu? paisaje se encuentra: Piedemonte
                       "f3_hills" = Characterizationfinca_wide$K1_5_4_3,#	341	Finca 1: En qu? paisaje se encuentra: Lomer?o (lomas, mesas y vallecitos)
                       "f3_other" = Characterizationfinca_wide$K1_5_5_3,#	341	Finca 1: En qu? paisaje se encuentra: Otro, ?cu?l?
                       "f3_living_on_farm" = Characterizationfinca_wide$J1_CVF_3,#	341	Finca 1: Vive en la finca
                       "f3_transport_method" = Characterizationfinca_wide$K1_6_3,#	56	Finca 1: Si no vive en la finca, cu?l es el m?todo de transporte usado con m?s f
                       "f3_motorbike" = Characterizationfinca_wide$K1_6_1_3,#	341	Finca 1: M?todo de transporte usado: Moto
                       "f3_own_car" = Characterizationfinca_wide$K1_6_2_3,#	341	Finca 1: M?todo de transporte usado: Carro particular
                       "f3_walking" = Characterizationfinca_wide$K1_6_3_3,#	341	Finca 1: M?todo de transporte usado: Caminando
                       "f3_horseback" = Characterizationfinca_wide$K1_6_4_3,#	341	Finca 1: M?todo de transporte usado: Caballo
                       "f3_public_transport" = Characterizationfinca_wide$K1_6_5_3,#	341	Finca 1: M?todo de transporte usado: transporte p?blico
                       "f3_canoe" = Characterizationfinca_wide$K1_6_6_3,#	341	Finca 1: M?todo de transporte usado: Canoa
                       "f3_other_transport" = Characterizationfinca_wide$K1_6_7_3,#	341	Finca 1: M?todo de transporte usado: Otro.?Cu?l?
                       "f3_time_of_travel" = Characterizationfinca_wide$K1_7_3,#	57	Finca 1: Tiempo promedio requerido (Horas)
                       "f3_area_total" = Characterizationfinca_wide$K2_1_3,#	340	Finca 1: ?rea total de la finca
                       "f3_area_permanent_cultures" = Characterizationfinca_wide$K2_2_3,#	310	Finca 1: ?rea en cultivos permanentes  incluyendo pasto de corte o banco forraje
                       "f3_area_pasture_wo_sps" = Characterizationfinca_wide$K2_4_3,#	338	Finca 1: ?rea en pasturas  sin incluir las que estan en sistemas silvopastoriles
                       "f3_area_fallow" = Characterizationfinca_wide$K2_6_3,#	324	Finca 1: ?rea en descanso rastrojo
                       "f3_area_sps" = Characterizationfinca_wide$K2_7_3,#	309	Finca 1: Silvopastoril  sin incluir pasto de corte o banco forrajero
                       "f3_area_agroforestry" = Characterizationfinca_wide$K2_8_3,#	305	Finca 1: ?rea agroforestal
                       "f3_area_forest" = Characterizationfinca_wide$K2_10_3#	323	Finca 1: ?rea en bosque
)

save(farm3.df, file="0_SALDatabase/QuantitativeAnalysisSilvopastoriles/Dataframes/farm3.df.Rda")

silvopasture.df <- data.frame("id_house" =Characterizationfinca_wide$ID_HOUSE,   
  "type_of_sps"=Characterizationfinca_wide$K2_P_2,	#334	Si tiene sistema sistema silvopastoril, ?de que tipo es?   [Opci?n m?ltiple]
  "dispersed_trees"=Characterizationfinca_wide$K2_P_2_1,	#340	?rbustos dispersos
  "forage_banks"=Characterizationfinca_wide$K2_P_2_2,#	340	Banco de forrajes
  "intense_sps"=Characterizationfinca_wide$K2_P_2_3,	#340	Silvopastoril intensivo
  "living_fences"=Characterizationfinca_wide$K2_P_2_4,	#341	Cercas vivas
  "trees_in_lines"=Characterizationfinca_wide$K2_P_2_5,	#340	?rboles en franjas
  "does_apply"=Characterizationfinca_wide$K2_P_2_6	#0	No aplica
)
summary(silvopasture.df)
save(silvopasture.df, file="0_SALDatabase/QuantitativeAnalysisSilvopastoriles/Dataframes/silvopasture.df.Rda")


Livestock<- read.dta13("N_Ganaderia/Submodulos_long/N7_Mano_de_obra_long.dta")


# 850	MODULO_N7	Modulo N. Ganado (N12)	N12_C1	A continuaci?n se preguntara por trabajo familiar asociado a ganado
 #N12_1	1380	Actividad				
 # 851	MODULO_N7	Modulo N. Ganado (N12)	N12_2	Total de jornales por hombres (trabajo familiar)
	#Total de jornales por mujeres (trabajo familiar)
 # 853	MODULO_N7	Modulo N. Ganado (N12)	N12_4	Total de jornales por ni?os (trabajo familiar)
# 854	MODULO_N7	Modulo N. Ganado (N12)	N12_C2	A continuaci?n se preguntara por trabajo contrarado asociado a ganado
 # 855	MODULO_N7	Modulo N. Ganado (N12)	N12_5	Total de jornales por hombres (trabajo contratado)
 # 856	MODULO_N7	Modulo N. Ganado (N12)	N12_6	Total de jornales por mujeres (trabajo contratado)
 # 857	MODULO_N7	Modulo N. Ganado (N12)	N12_A	Costo total (Dinero y especie) por dia (Pesos) por hombres (trabajo contratado)
# 858	MODULO_N7	Modulo N. Ganado (N12)	N12_B	Costo total (Dinero y especie) por dia (Pesos) por mujeres (trabajo contratado)

workforce_cattle.df <- data.frame("id_house" = Livestock$ID_HOUSE, # ID_HOUSE	2046	ID_HOUSE
                                  "livestock_activity" = Livestock$N12_1,# N12_1	1380	Actividad
# N12_1_1	1	Actividad, Especifique
"activity_executed" = Livestock$N12_2, # N12_2	1380	Realiza la actividad?
"total_familiy_workdays_man" = Livestock$N12_3_1,# N12_3_1	481	Trabajo familiar: Total de jornales por hombres (8h)
"total_familiy_workdays_woman" = Livestock$N12_3_2,# N12_3_2	482	Trabajo familiar: Total de jornales por mujeres (8h)
"total_familiy_workdays_kids" = Livestock$N12_3_3,# N12_3_3	484	Trabajo familiar: Total de jornales por niños (8h)
"total_contracted_workdays_man" = Livestock$N12_4_1_1,# N12_4_1_1	127	Trabajo contratado: Total de jornales por hombres (8h)
"total_contracted_workdays_woman" = Livestock$N12_4_1_2,# N12_4_1_2	112	Trabajo contratado: Total de jornales por mujeres (8h)
"total_costperday_contracted_work_man" = Livestock$N12_4_2_1,# N12_4_2_1	126	Trabajo contratado:Costo total Dinero y especie por día
"total_costperday_contracted_work_woman" = Livestock$N12_4_2_1# N12_4_2_2	1378	Trabajo contratado:Costo total Dinero y especie por día
, stringsAsFactors = FALSE)
save(workforce_cattle.df, file = "0_SALDatabase/QuantitativeAnalysisSilvopastoriles/Dataframes/workforce_cattle.df.Rda")


comercial_activity.df <- read.dta13("N_Ganaderia/Submodulos_long/N5_Actividades_comerciales_long.dta")

comercial_activity.df <- subset(comercial_activity.df, N10_1 %in% c(
                                                 "Novillas Levante (1-2 años)",
"Novillas Levante (1-2 años)",                       
"Novillas Vientre (2-3 años)",                     
"Novillos de Ceba (2-3 años)Machos 2-3 año",
"Terneras (0-1 año)",                                
"Terneros (0-1 año)",                                
"Toros y Toretes (mayor de 3 años)Machos más 3 años",
"Vacas Horras/Secas/escoteras",                      
"Vacas Paridas (Aplica para los sistemas de cría)",  
"Vacas en Producción (En ordeño)",
"Machos de Levante (1-2 años)Machos 1-2 años"
))
colnames(comercial_activity.df)
Variable	Obs	Label

ID_HOUSE	4140	ID_HOUSE
N10_1	4140	Animal
N10_1_1	14	Animal: Especifique
N10_1_2	4140	Posee este tipo de animales?
  N10_2_1	1106	Del # total que tenía (últimos 12 meses), Cuántos fueron para autoconsumo?
N10_2_2	1111	Del # total de animales que tenía (ultimos 12 meses), Cuántos fueron vendidas?
N10_2_2_0	0	Vendió?
  N10_2_2_1_1	60	Quién decide cuándo vender un animal? ID persona 1
N10_2_2_1_2	45	Quién decide cuándo vender un animal? ID persona 2
N10_2_2_1_3	6	Quién decide cuándo vender un animal? ID persona 3
N10_2_2_1_4	4	Quién decide cuándo vender un animal? ID persona 4
N10_2_2_1_5	2	Quién decide cuándo vender un animal? ID persona 5
N10_2_2_1_6	1	Quién decide cuándo vender un animal? ID persona 6
N10_2_2_1_7	1	Quién decide cuándo vender un animal? ID persona 7
N10_2_2_1_8	1	Quién decide cuándo vender un animal? ID persona 8
N10_2_2_2	92	Razón de venta del animal?
  N10_2_2_3	91	Cuál fue el Precio de venta durante los últimos 12 meses?
  N10_2_2_3_1	92	Unidad de venta
N10_2_2_3_2	15	Unidad de venta- Otros
N10_2_2_4	92	A quién le vendió?
  N10_2_2_4_1	3	A quién le vendió? Especifique
N10_2_2_5	92	Dónde realizo la venta?
  N10_2_2_5_1	1	Dónde realizó la venta? Especifique
N10_2_2_6	90	Si lo vendió fuera de su finca, utilizó transporte para realizar la venta?
  N10_2_2_6_1	1	Utilizó transporte para realizar la venta? Especifique N10_2_2_6
N10_2_2_7	80	Cuánto le cuesta en promedio cada viaje? (COP pesos)
N10_2_2_8	82	Qué número de viajes necesitó para vender el total del producto?
  N10_2_2_9	87	Quién decide en qué gastar el dinero que se genera con…? Ver ID persona


# 826	MODULO_N6	Modulo N. Ganado (N11)	N11_6	?Cu?l fue la producci?n Anual total (leche) ultimos 12 meses?
# 827	MODULO_N6	Modulo N. Ganado (N11)	N11_7	Unidades
# 828	MODULO_N6	Modulo N. Ganado (N11)	N11_7A	Unidades (especifique)
# 829	MODULO_N6	Modulo N. Ganado (N11)	N11_8	Dividir la producci?n seg?n su uso(debe quedar expresado en las mismas unidades de medida de la producci?n anual) (Autoconsumo)
# 830	MODULO_N6	Modulo N. Ganado (N11)	N11_9	Dividir la producci?n seg?n su uso(debe quedar expresado en las mismas unidades de medida de la producci?n anual) (Venta)
# 831	MODULO_N6	Modulo N. Ganado (N11)	N11_10	Dividir la producci?n seg?n su uso(debe quedar expresado en las mismas unidades de medida de la producci?n anual) (Otro)
# 832	MODULO_N6	Modulo N. Ganado (N11)	N11_10A	Dividir la producci?n seg?n su uso(debe quedar expresado en las mismas unidades de medida de la producci?n anual) (Especifique)
# 833	MODULO_N6	Modulo N. Ganado (N11)	N11_11	?Quien realiz? la venta? [opci?n m?ltiple] ID persona
# 834	MODULO_N6	Modulo N. Ganado (N11)	N11_12	?Cu?l fue el Precio promedio de venta por unidad durante los ultimos 12 meses ?
# 835	MODULO_N6	Modulo N. Ganado (N11)	N11_12U	?Cu?l fue el Precio promedio de venta por unidad durante los ultimos 12 meses ?  (Unidades)
# 836	MODULO_N6	Modulo N. Ganado (N11)	N11_12_1	Vendi?
# 837	MODULO_N6	Modulo N. Ganado (N11)	N11_13	?A quien le vendio?
# 838	MODULO_N6	Modulo N. Ganado (N11)	N11_13A	?A quien le vendio? (Especifique)
# 839	MODULO_N6	Modulo N. Ganado (N11)	N11_14	?Donde realizo la venta?
# 840	MODULO_N6	Modulo N. Ganado (N11)	N11_14A	?Donde realizo la venta? (Especifique)
# 841	MODULO_N6	Modulo N. Ganado (N11)	N11_15	Si lo vendio fuera de su finca, ?utiliz? alg?n medio de transporte para realizar la venta?
# 842	MODULO_N6	Modulo N. Ganado (N11)	N11_15A	Si lo vendio fuera de su finca, ?utiliz? alg?n medio de transporte para realizar la venta? (Especifique)
# 843	MODULO_N6	Modulo N. Ganado (N11)	N11_16	Cuanto le cuesta en promedio cada viaje? ($Pesos)
# 844	MODULO_N6	Modulo N. Ganado (N11)	N11_17	?Que n?mero de viajes necesito para vender el total del producto?
# 845	MODULO_N6	Modulo N. Ganado (N11)	N11_18	?Qui?n decide en qu? gastar el dinero que se genera con la venta? (Ver ID)
# 846	MODULO_N6	Modulo N. Ganado (N11)	N11_C2	?Desea agregar otro derivado lacteo?
# 847	MODULO_N7	Modulo N. Ganado (N12)	N12_1	Actividad
# 848	MODULO_N7	Modulo N. Ganado (N12)	N12_1A	Actividad (Especifique)
# 849	MODULO_N7	Modulo N. Ganado (N12)	N12_1_1	?Realiza la actividad?
# 
# 
# 
# #1028	OBSERVACIONES	Observaciones	K_C0	K.1 ?Cu?ntas fincas tiene a su disposici?n para la explotaci?n agropecuaria y/o acu?cola. (tambien incluye plantaciones y explotacion forestal)?
# 


# # 1040	OBSERVACIONES	Observaciones	K2_P_2	Si tiene sistema sistema silvopastoril, ?de que tipo es?   [Opci?n m?ltiple]
# # 1041	OBSERVACIONES	Observaciones	K2_P_2_1	?rbustos dispersos
# # 1042	OBSERVACIONES	Observaciones	K2_P_2_2	Banco de forrajes
# # 1043	OBSERVACIONES	Observaciones	K2_P_2_3	Silvopastoril intensivo
# # 1044	OBSERVACIONES	Observaciones	K2_P_2_4	Cercas vivas  
# # 1045	OBSERVACIONES	Observaciones	K2_P_2_5	?rboles en franjas
# # 1046	OBSERVACIONES	Observaciones	K2_P_2_6	No aplica


