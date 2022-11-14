
# LFU Function Used
class LFU():
    # Main Function 
    def main_func(self,input_frame,data_excel):
        data_dict = []          # <-- Data From excel
        data_frame = []         # <-- Data Frame init
        page_hit = []           # <-- Page Hit list
        page_falut = []         # <-- Page Fault list
        page_replace_step = []  # <-- Step by Step list

        for index in range(len(data_excel)): data_dict.append([data_excel[index],0,0]) # <-- Setup data
        for i in range(input_frame): data_frame.append(None)  # <-- Setup DataFrame Input

        for i in range(len(data_dict)):
            page_replace_step.append(self.__TransData(data_frame))
            for j in range(len(data_frame)):  # <-- Count data frame
                # Case 1 : Frame is empty
                if data_frame[j] == None:
                    page_falut.append(data_dict[i][0])
                    data_frame = self.__UpdataPriority(data_frame)
                    data_frame[j] = data_dict[i] # <-- Place data to data_frame
                    break

                # Case 2 : Data is in Frame
                elif data_dict[i][0] == data_frame[j][0]:
                    data_frame = self.__UpdataPriority(data_frame)
                    data_frame[j][1] += 1  # <-- DataFreq += 1
                    page_hit.append(data_dict[i][0])
                    break

                # Case 3 : Data isn't in Frame
                elif None not in data_frame and self.__CheckDataFrame(data_frame, data_dict[i][0]):
                    ref = sorted(data_frame, key = lambda i:i[1])     # <-- Sort Freq
                    temp = [] 
                    ch = True                                         # <-- Assign True to tell this DataFrame have Least Freq
                    for data in data_frame:
                        if ref[0][1] == data[1]: temp.append(data)    # <-- Least Freq must not more than one
                    if len(temp) > 1:                                 # <-- If Least Freq more than one 
                        temp = sorted(temp ,key= lambda i:i[2])       # <-- Sort DataFrame -> Priority to FIFO
                        ch = False                                    # <-- Change False to tell this DataFrame not have Least Freq 
                    for _ in range(len(data_frame)):                  # <-- Loop for find seat to replace
                        if (data_frame[_][1] == temp[0][1] and ch) or data_frame[_][2] == temp[-1][2]: # Con_1 : This DataFrame have Least Freq, Con_2 : not Least Freq Find FIFO
                            page_falut.append(data_dict[i][0])
                            data_frame = self.__UpdataPriority(data_frame)
                            data_frame[_] = data_dict[i]
                            break
                    break
        return page_replace_step,page_falut,page_hit

    def __UpdataPriority(self, data_frame): # <-- Update Priority in Data Frame
        for data in data_frame:
            if data != None:data[2] += 1
        return data_frame

    def __CheckDataFrame(self, data_frame, data): # <-- Check Data in Data Frame
        for i in data_frame:
            if i != None and i[0] == data:return False
        return True

    def __TransData(self, data_frame):  # <-- TranData for unlink old adress
        temp = []
        for i in data_frame:
            if i == None:temp.append(None)
            else:temp.append([int(i[0]),int(i[1]),int(i[2])])
        return temp
