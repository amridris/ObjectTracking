from datetime import datetime
import time
import serial, io
import sys
import numpy as np

print("PixyArduinoSerial...",time.strftime("%Y-%m-%d_%H-%M-%S"))
outfile = '../logs/pixy_raw.txt'
pixy_port = 'COM5'
pixy_baud = 9600

pixy_arduino_ser = serial.Serial()
pixy_arduino_ser.port = pixy_port
pixy_arduino_ser.baudrate = pixy_baud

num_numbers = lambda x: (len(x)-1)/2
iter_words = lambda x: x*2+3

def pixy_ser_parse(input):
    words = input.split(" ")
    size = num_numbers(words)
    numbers = np.zeros(size)
    for count in range(0,size):
        numbers[i] = words[iter_words(i)]
    return numbers

def pixy_ser_open():
    if not pixy_arduino_ser.isOpen():
        try:
            pixy_arduino_ser.open();
            piyx_sio = io.TextIOWrapper(
                io.BufferedRWPair(pixy_arduino_ser, pixy_arduino_ser, 1),
                encoding='ascii', newline='\r'
            )
        except:
            print("Error opening pixy_arduino_ser at:",pixy_port,"=>",sys.exc_info()[0])
  

def read_pixy_arduino_ser():
    with open(outfile, 'a') as f: #appends to existing file
        while ser.isOpen():
            datastring = pixy_sio.readline()
            f.write(datetime.utcnow().isoformat() + '\t' + datastring + '\n')
            f.flush() #included to force the system to write to disk
    pixy_arduino_ser.close()

if __name__== "__main__":
    while(1):
        while(not pixy_arduino_ser.isOpen()):
            pixy_ser_open()
            input("Press Enter to continue...")
        open(outfile)
    if(pixy_arduino_ser.isOpen()):
        pixy_arduino_ser.close()