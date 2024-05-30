#!/bin/bash

# Pick a favourite among engineering fields using case

echo -e "1. Chemical\\n2. Computer"

read -p "Which engineering would you choose: " choice
output="Great choice of major in"

# Convert input to lower case
case ${choice,,} in
	"chemical")
		echo -e "1. Applied Chemistry\\n2. Biomedical"
    		read -p "Which major would you choose in "$choice": " sub_choice
    		case ${sub_choice,,} in
    			"applied chemistry")
    			# Capitalize majors and branch
    				printf '%s%s%s engineering' "${output} ${sub_choice^} - ${choice^}"	
    			;;
    			"biomedical")
    				printf '%s%s%s engineering' "${output} ${sub_choice^} - ${choice^}"	
    			;;
    			*)
			    printf "Invalid entry. Please choose from applied chemistry and biomedical"
			    ;;
    		esac
    	;;

  "computer")
  		echo -e "1. Web development\\n2. Cyber security"
    		read -p "What would you choose in "$choice": " sub_choice
    		case ${sub_choice,,} in
    			"web development")
    				printf '%s%s%s engineering' "${output} ${sub_choice^} - ${choice^}"	
    			;;
    			"cyber security")
    				printf '%s%s%s engineering' "${output} ${sub_choice^} - ${choice^}"	
    			;;
    			*)
			    printf "Invalid entry. Please choose from web development and cyber security"
			    ;;
    		esac
    ;;

  *)
    printf "Invalid entry. Please choose from chemical and computer"
    ;;
esac
