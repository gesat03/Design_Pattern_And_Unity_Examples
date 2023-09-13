using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GarbageCollector
{
    public static class GarbageCollection 
    {

        public static void GarbageCollectionTrack()
        {
            // Bellek kullanımını takip etmek için başlangıçta bir log oluşturun.
            long startMemory = System.GC.GetTotalMemory(false);
            Debug.Log("Başlangıç Bellek Kullanımı: " + startMemory);

            // Garbage collection işlemi başlatın.
            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();

            // Bellek kullanımını yeniden ölçün ve sonuçları loglayın.
            long endMemory = System.GC.GetTotalMemory(false);
            Debug.Log("Garbage Collection Sonrası Bellek Kullanımı: " + endMemory);

            // Garbage collection işlemi sonrasındaki bellek kullanımı ile başlangıçtaki bellek kullanımı arasındaki farkı hesaplayın.
            long memoryUsageDifference = endMemory - startMemory;
            Debug.Log("Garbage Collection Sonucu Bellek Kullanımı Farkı: " + memoryUsageDifference + " byte");
        }

    }
}
