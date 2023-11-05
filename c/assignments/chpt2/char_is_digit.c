/*
    Write a program to check if given character is digit or not
*/
#include<stdio.h>
#include<ctype.h>
int main () {
    
    char c;
    printf("Enter a char: ");
    scanf("%c", &c);

    // Will check against numbers from 0 to 9 only
    if (isdigit(c)) {
        printf("%c is a digit\n", c);
    } else {
        printf("%c is not a digit\n", c);
    }

    return 0;
}