#!/bin/bash
# List all the contents of the directory without any command

# Get the directory name
read -p "Enter a directory path: " dir
home_dir="/home/$(whoami)"

# Check if the input is a valid directory
if [ -d $dir ]; then
	# Loop through one level up of the directory
	for file in $dir/*; do
		# Print only directory contents
		# ${data##pattern} - remove pattern with long match from data
		# In this case, will remove all the contents till /
		printf '%s\n' "${file##*/}"
	done
# for home directory contents
elif [[ $dir == "~" ]]; then
	for file in $home_dir/*; do
		printf '%s\n' "${file##*/}"
	done
		
else
	printf "Invalid directory path"
fi			
