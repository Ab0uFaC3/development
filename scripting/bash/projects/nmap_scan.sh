#!/bin/bash

ip_address="$1"

# If IP address is not valid
if [[ $ip =~ ^([0-9]{1,3}\.)[0-9]{1,3}$ ]]
then
    echo -e "Invalid ip\n"
    echo -e "Format 0-255.0-255.0-255.0-255"
    exit 1
fi

# Normal nmap scan
# Store the result in file
nmap -T4 -p- $ip_address | cat > nmap.txt &

# Extract the ports from above scan
# Read from nmap.txt file, separate 1st column with delimiter space. Filter on rows with word "/tcp" and comma separate all the ports found
port_range=$(cat nmap.txt | cut -d " " -f1 | grep "/tcp" | sed 's/\/tcp/\,/g;$s/\,$//g' | tr '\n' ' ')

# Pass the ports to another nmap scan and store results in final.txt file
nmap -T4 -A $port_range $ip_address > final.txt &