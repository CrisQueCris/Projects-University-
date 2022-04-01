#Function transform factor to logical

TransformFactorToLogical <- function(x){
levels(x)<- c(TRUE, FALSE)
x <- as.logical(x)
return(x)
}


