namespace HomeWork3_7_2; 
public static class Extensions {
    public static void Sort(this Train[] arr) {
        for (int i = 0; i < arr.Length - 1; i++) {
            for (int j = i + 1; j < arr.Length; j++) {
                if (arr[i].TrainNumber > arr[j].TrainNumber){
                    var tmp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = tmp;
                }
            }
        }
    }

}
