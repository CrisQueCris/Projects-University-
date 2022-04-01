#TLU calculations
#Load Function and Dataframe
source("Functions/CalculateTLU.R")
load("Dataframes/animals.df.Rda")

#Build dataframe TLU, add TLU of each animal by using CalculateTLU
TLU <- data.frame(animals.df[,1])
animals.df[,29:51] <- NULL
i<-2
for (j in seq(from=2, to=length(colnames(animals.df)), by=3)){
TLU_Column <- CalculateTLU(animals.df[,j], animals.df[,j+1], animals.df[,j+2])
TLU <- cbind(TLU, TLU_Column)
colnames(TLU)[i] <- paste("TLU", colnames(animals.df)[j], sep="_")
i<-i+1
}
TLU_total <- rowSums(TLU[,2:length(colnames(TLU))])
TLU <- cbind(TLU, TLU_total)

# Add TLU to animals.df

animals.df <- cbind(animals.df, TLU[,2:length(colnames(TLU))])    

#Save animals.df

save(animals.df, file=("Dataframes/animals.df.Rda"))
save(TLU, file = "Dataframes/TLU.df.Rda")


