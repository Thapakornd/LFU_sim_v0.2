
# LFU Alan 
class F_data:
    def __init__(self, data, freq):
        self.data = data
        self.freq = freq
class Age_data:
    def __init__(self, data, age):
        self.data = data
        self.age = age

class LFU():
    def mainfunc(self,input_frame,data_excel): #function for C# to call varible
        # valuable----------------------
        all_data = [] # array of all the data
        data_frame = [] # frame for page fault
        frequent = [] # array for referncing frequency
        T_frame = [] # page hit
        F_frame = [] # page fault
        timeline_frame = []  # timeline each frame
        frequent_timef = []  # timeline each frequent

        # function------------------------
        def __TransData(data_frame):  # <-- Transfer data and keep to array
            temp = []                 # <-- Why don't direct append because it will link data freq start and end are same.
            for i in data_frame:
                if i == None:temp.append(None)      # <-- If None append None
                else: temp.append([i.data,i.age])   # <-- else append Data Infomation
            return temp
        def __TransFreq(freq):        # <-- Transfer data_freq keep to array
            temp = []                
            for i in freq:                         # <-- Don't have conditon because we count freqent array if freq = 10, we append 10 round
                temp.append([i.data,i.freq])       # <-- Apppend data freq
            return temp

        def check_freq(self):
            return self.freq
        def check_age(self):
            return self.age
        def count(self): # count number frequency
            if frequent == []:
                frequent.append(F_data(self, 1))
            else:
                k = 0
                for i in range(len(frequent)):
                    if self == frequent[i].data:
                        frequent[i].freq += 1
                        k += 1
                        break
                if k == 0:
                    frequent.append(F_data(self, 1))
        def LFU(self):
            global F_frame
            ref = []
            for i in range(len(data_frame)):
                for x in range(len(frequent)):
                    if data_frame[i].data == frequent[x].data:
                        ref.append(frequent[x])
                        break
            ref.sort(key=check_freq)
            fifo = []
            fifo.append(ref[0])
            for i in range(1, len(ref)):
                if i < len(ref):
                    if ref[i].freq == fifo[0].freq:
                        fifo.append(ref[i])
            data_frame.sort(key=check_age)
            for i in range(len(data_frame) - 1, -1, -1):
                q = 0
                for x in range(len(fifo)):
                    if data_frame[i].data == fifo[x].data:
                        data_frame[i].data = self
                        data_frame[i].age = 0
                        count(self)
                        q += 1
                        break
                if q == 1:
                    break
        # Appending alldata--------------------
        for i in range(len(data_excel)):
            all_data.append(data_excel[i])
        # appending data frame--------------------
        for i in range(input_frame):
            data_frame.append(Age_data(None,None))
        # processing data-------------------
        for i in range(len(data_excel)):
            timeline_frame.append(__TransData(data_frame))
            frequent_timef.append(__TransFreq(frequent))
            p = 0
            for x in range(len(data_frame)):  # <-- Case 1 : Data is in frame
                if all_data[i] == data_frame[x].data:  # <-- Hit
                    count(all_data[i])
                    T_frame.append(all_data[i])     # <-- Append Page Hit to list
                    p += 1
                    break
            if p == 0:  # <-- Case 2 : No data in data_frame
                k = 0
                for x in range(len(data_frame)):
                    if data_frame[x].data == None:  # <-- if frame has "None" seat
                        data_frame[x] = (Age_data(all_data[i],0))
                        count(all_data[i])
                        k += 1
                        F_frame.append(all_data[i])  # <-- Append Page Fault to list.
                        break
                if k == 0:
                    LFU(all_data[i])
                    F_frame.append(all_data[i])      # <-- Append Page Fault to list.
            for j in range(len(data_frame)):
                if data_frame[j].data != None:
                    data_frame[j].age += 1
        timeline_frame.append(__TransData(data_frame))   # <-- Append last Data information.
        frequent_timef.append(__TransFreq(frequent))     

        return timeline_frame,F_frame,T_frame,frequent_timef
