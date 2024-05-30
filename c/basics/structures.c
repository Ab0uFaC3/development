/*
    WHAT ARE STRUCTURES?
    used to store data of different DT together and all members are assigned different designated memory location
*/

#include<stdio.h>
#include <string.h>

typedef struct Movies
{
    char name [100];
    float rating;
    int release_year;
} movies;


int main () {
    movies movie;
    strcpy(movie.name, "ABC");
    movie.rating = 2.5;
    movie.release_year = 2021;

    printf("%s\n", movie.name);
    printf("%.2f\n", movie.rating);
    printf("%d\n", movie.release_year); 

    return 0;
}