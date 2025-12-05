def main():
    dial_pos = 50
    zero_count = 0
    with open("../input.txt", "r") as input:
        for line in input:
            move = 0
            zero_start = dial_pos == 0
            if len(line) == 2:
                move = int(line[1])
            elif len(line) == 3:
                move = int(line[1:3])
            elif len(line) == 4:
                move = int(line[1:4])
            else:
                move = int(line[1:5])
            if dial_pos == 0 and move % 100 == 0:
                print(str(dial_pos) + "," + str(move))
            print("Dial Position: " + str(dial_pos))
            print("Line: " + line)
            print("Move: " + str(move))
            print("Old Zero Count: " + str(zero_count))
            zero_count += move // 100
            print("New Zero Count: " + str(zero_count))
            move %= 100 
            print("New Move: " + str(move))
            if line[0] == "R":
                dial_pos += move
            else:
                dial_pos -= move
            print("Pre-shift dial position " + str(dial_pos))
            if dial_pos > 99:
                dial_pos = dial_pos - 100
                zero_count += 1
            elif dial_pos < 0:
                dial_pos = dial_pos + 100
                if not zero_start:
                    zero_count += 1
            elif dial_pos == 0:
                zero_count += 1
            print("New Dial Position: " + str(dial_pos))
            print("-----------------------------------------")
        print("Zeros counted:  " + str(zero_count))

if __name__ == "__main__":
    main()