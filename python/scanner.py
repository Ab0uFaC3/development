#!/bin/python3

import sys
import datetime
import socket
import ipaddress

def validate_ip(ip):
	try:
		if len(ip) == 0:
			return False, "Enter an ip address"
		else:
			# validates whether given ip address is valid
			ip_obj = ipaddress.ip_address(ip)
			return True, f"The IP address {ip} is valid"
	except ValueError:
		return False, f"The IP address {ip} is not valid"
			

if len(sys.argv) == 2:
	# Get the ip address from the arg and validate it
	result = validate_ip(sys.argv[1])
	if result[0]:
	# If valid, get the ip from hostname
	#target = socket.gethostbyname(sys.argv[1])
		target = sys.argv[1]
		print("-" * 50)
		print(result[1])
	else:
		print("-" * 50)
		print(result[1])
else:
	print("Invalid no of arguments")
	print("python3 filename ip_address")


try:
	for port in range(50, 90):
		# Connection for ipv4 and port
		s = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
		# Set connection timeout of 1 sec
		socket.setdefaulttimeout(1)
		# Connect to the target ip and port and return the result
		# if port is open, return 0 else 1
		ans = s.connect_ex((target, port))
		if ans == 0:
			print(f"Port {port} is open")
		# Close the connection to the port
		s.close()

except socket.error:
	print("Could not connect to the server")
	sys.exit()
	
except KeyboardInterrupt:
	print("\nExiting program")
	sys.exit()
