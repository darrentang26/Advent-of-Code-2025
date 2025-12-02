def main():
    dial_pos = 50
    zero_count = 0
    with open("../input.txt", "r") as input:
        for line in input:
            move = 0
            if len(line) == 2:
                move = int(line[1])
            elif len(line) == 3:
                move = int(line[1:3])
            else:
                move = int(line[1:4])
            move %= 100 
            print(line[:-1] + " | " + str(move))
            if line[0] == "R":
                dial_pos += move
            else:
                dial_pos -= move
            if dial_pos > 99:
                dial_pos = dial_pos - 100
            elif dial_pos < 0:
                dial_pos = dial_pos + 100
            if dial_pos == 0:
                zero_count += 1
            if dial_pos > 99 or dial_pos < 0:
                print("Dial out of bounds")
            print("Dial Position: " + str(dial_pos))
        print("Zeros counted:  " + str(zero_count))

if __name__ == "__main__":
    main()