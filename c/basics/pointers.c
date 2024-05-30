/*
    WHAT ARE POINTERS?
    variables that hold memory address
*/

#include<stdio.h>
#include<stdlib.h>

void static_function () {
    
    static int static_var = 10;
    int non_static_var = 10;

    static_var += 5;
    non_static_var += 5;

    printf("%d %d\n", static_var, non_static_var);
}

int main() {
    //Declaring a pointer - holds mem address of integer
    int *pointer;

    // Initializing pointer
    int value = 25;
    pointer = &value;

    // printf("%p\n", &value);
    // printf("%p\n", pointer);

    /*
        Dereferencing a pointer:
        access or modify the value whose address is stored by the pointer
    */
//    printf("%d\n", *pointer);

   /*
        Pointer to pointer:
        point to another pointer variable's address
   */
    int **pointer_to_pointer = &pointer;
    // printf("%d\n", **pointer_to_pointer);

    int arr[] = {1,2};
    int *arr_pointer = arr;
    // printf("%d\n", *arr_pointer);

    /*
        VOID Pointer:
        DT given to pointer to further typecast into another DT
    */
    int int_value = 1;
    void *void_pointer = &int_value;



    /*
        STATIC Keyword:
        1. Static defined local variables => value is persistent during function call with scope confined to the function.
        2. Static global variables => not accessible outside the defined file
        3. Static functions => not accessible outside the defined file
    */

    for (int i = 0; i < 5; i++)
    {
        static_function();
        /*
            Output:
            
            Static Var          Non Static Var
                15                      15
                20                      15
                25                      15
                30                      15
                35                      15
        */
    }

    return 0;
}