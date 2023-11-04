/*
    Take a number (n) from user and output its cube (n * n * n)
*/
#include<stdio.h>
int main () {
    float n;
    printf("Enter a number: ");
    scanf("%f", &n);

    printf("Cube = %.3f\n", n * n * n);
    return 0;
}