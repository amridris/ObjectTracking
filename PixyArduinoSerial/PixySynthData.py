import time
import io

outfile = "logs/pixylog" + time.strftime("%Y-%m-%d_%H-%M-%S") + ".csv"

def synthetic_pixy_data():
    x,y,h,w = 100,100,50,50
    return str(x)+','+str(y)+','+str(h)+','+str(w)

def generate_pixy_data(times):
    with open(outfile, "w+") as pixy_log:
        for i in range(0, times):
           pixy_log.write(synthetic_pixy_data()+'\n')

if __name__ == "__main__":
    print(synthetic_pixy_data())
    generate_pixy_data(5);
