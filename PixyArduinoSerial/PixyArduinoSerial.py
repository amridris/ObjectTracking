from datetime import datetime
import serial, io

print("PixyArduinoSerial...")
outfile = '/tmp/pixy_raw.txt'
pixy_port = 'COM5'
pixy_baud = 9600

ser = serial.Serial(
    port=pixy_port,
    baudrate=pixy_baud,
)

sio = io.TextIOWrapper(
    io.BufferedRWPair(ser, ser, 1),
    encoding='ascii', newline='\r'
)

with open(outfile, 'a') as f: #appends to existing file
    while ser.isOpen():
        datastring = sio.readline()
        f.write(datetime.utcnow().isoformat() + '\t' + datastring + '\n')
        f.flush() #included to force the system to write to disk
ser.close()