#!/bin/python3

# pip3 install pycrypto
# pip3 install crypto
# pip3 install pycryptodome

import hashlib
import base64
import getpass
from Crypto.Cipher import AES
from Crypto.Protocol.KDF import PBKDF2
from Crypto.Util.Padding import pad, unpad

class EncryptDecrypt():
    def __init__(self, key, interactions=1000):
    	# Defining block size
        self.block_size = AES.block_size
        # hashing key using SHA256
        self.key = hashlib.sha256(key.encode()).digest()
        self.interactions = interactions
        # Converting to bytes array
        self.salt = bytes([0xab, 0x52, 0xd7, 0x73, 0xee, 0x00, 0xfc, 0x19])
        
    def create_cipher(self):
        try:
            # Rfc282Derivative equivalent in C#
            keyiv = PBKDF2(self.key, self.salt, 48, self.interactions)
            # 1st 32 bytes as key, next 12 bytes as IV
            key = keyiv[:32]
            iv = keyiv[32:48]
            # Generating cipher using AES, key, CBC mode and IV
            return AES.new(key, AES.MODE_CBC, iv)
        except:
            print("Error: Invalid cipher")
            
    def encrypt(self, input_string):
        try:
            # Encoding the input string
            # Adding padding to input with block size
            encoded_input_with_pad = pad(input_string.encode('utf-8'), self.block_size)
            
            # Call cipher function for encrypting the plain text
            cipher = self.create_cipher()
            
            # Encrypt the plain text
            # Encode the cipher text to base64 and convert to UTF-8 string
            return str(base64.b64encode(cipher.encrypt(encoded_input_with_pad)), "utf-8")
        except:
            print("Error: Invalid string")
     
    def decrypt(self, cipher_text):
        try:
            # Decode the cipher text from base64
            encrypted_cipher_text = base64.b64decode(cipher_text, validate=False)
            
            # Call cipher function for decrypting to plain text
            cipher = self.create_cipher()
            
            # Decrypt to plain text
            # Removing padding to input with block size
            # Convert the output to UTF-8 string
            return str(unpad(cipher.decrypt(encrypted_cipher_text), self.block_size), "utf-8")
        except:
            print("Error: Invalid string")
     	

# Fetch the password without displaying
enc = EncryptDecrypt(getpass.getpass(prompt='First entry: '))

choice = input("Action to perform:\n1. Encrypt \n2. Decrypt\n")
match choice:
	case "1":
		# Fetch the plain input string
		output_cipher_text = enc.encrypt(input('Enter the plain text: '))
		print(output_cipher_text)
	case "2":
		# Fetch the cipher input string
		output_plain_text = enc.decrypt(input("Enter the cipher text: "))        
		print(output_plain_text)
	case _:
		print("Invalid choice") 