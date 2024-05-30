/*
    WHAT ARE UNIONS?
    used to store data of different DT together but all the members share the same memory
    thus, values cannot be stored in them simultaneously
*/

#include<stdio.h>
#include <string.h>

typedef union Movies
{
    char name [100];
    float rating;
    int release_year;
} movies;


int main () {
    movies movie;

    /*
        Only last value will be assigned (release_year)

        strcpy(movie.name, "ABC");
        movie.rating = 2.5;
        movie.release_year = 2021;

        printf("%s\n", movie.name);
        printf("%.2f\n", movie.rating);
        printf("%d\n", movie.release_year); 
    */

    strcpy(movie.name, "ABC");
    printf("%s\n", movie.name);

    movie.rating = 2.5;
    printf("%.2f\n", movie.rating);

    movie.release_year = 2021;
    printf("%d\n", movie.release_year); 

    return 0;
}