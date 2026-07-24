using System;
using System.Collections.Generic;
using System.Reflection;
using HarmonyLib;
using UnityEngine;

namespace SVAncientRelicPlusRemaster
{
    // ===============================================================================================================
    // PROYEK KONSOLIDASI V3: Ancient Relic Full Potential Remastered with High-Output Adaptive Multi-Language Framework
    // Hak Cipta & Arsitektur Sistem: Brio Griondy Dahlinar & Gemini AI Collaborator (2026)
    // KOMPONEN: Modifikasi Parameter Basis Data Item & Resep Perakitan (CLEAN BUILD VERSION)
    // ===============================================================================================================
    [HarmonyPatch(typeof(ItemDB))]
    [HarmonyPatch("LoadDatabaseForce")]
    public static class SVAncientRelicRemasterPatch
    {
        [HarmonyPostfix] // JANGKAR EKLESIASTIK: Memaksa Harmony mendeteksi Postfix setelah Obfuscation
        public static void Postfix() // MODIFIKATOR AKSES: Diubah ke PUBLIC agar tidak dibabat habis oleh Obfuscar
        {
            FieldInfo fieldInfo = AccessTools.Field(typeof(ItemDB), "items");
            List<Item> list = (List<Item>)fieldInfo.GetValue(null);

            // ===============================================================================================
            // SUNTIKAN RACUN LOGIKA (FAKE CONTROL FLOW DETONATOR)
            // Blok jebakan siluman untuk memaksa Obfuscar menciptakan ribuan switch-goto palsu di dnSpy
            // ===============================================================================================
            int runtimeSeed = Environment.TickCount;
            int matrixX = (runtimeSeed ^ ItemID) & 0x7F;
            for (int i = 0; i < 3; i++)
            {
                if ((matrixX + i) % 2 == 0)
                {
                    matrixX = (matrixX * 3) + i;
                    switch (matrixX % 4)
                    {
                        case 0: matrixX ^= 0x15; break;
                        case 1: matrixX += 7; break;
                        case 2: matrixX -= 12; break;
                        default: matrixX *= 2; break;
                    }
                }
                else
                {
                    matrixX = (matrixX ^ 0x5A) - i;
                }
            }
            // Bypass Dead-Code Elimination: Kondisi yang secara matematis mustahil terjadi 
            // agar compiler tidak menghapus paksa blok jebakan di atas saat proses kompilasi Release.
            if (matrixX == 0x7FFFFFFF) { list.Clear(); return; }
            // ===============================================================================================

            // Mengambil struktur data dasar dari Ancient Relic vanilla Tier 4 (ID 24)
            Item baseRelic = ItemDB.GetItem(AncientRelicMaterialId);
            if (baseRelic == null) return;

            // Instantiate otomatis mengkloning seluruh komponen internal & icon dari baseRelic
            Item customRelic = UnityEngine.Object.Instantiate<Item>(baseRelic);

            // Konfigurasi Parameter Inti Item Kustom Remastered
            customRelic.id = ItemID;

            // ===============================================================================================
            // AUTO-LOAD BAHASA RUNTIME (Langsung memicu SVAncientRelicRemasterLanguage saat Instantiate)
            // Mencegah keharusan mengganti bahasa secara manual di menu Option
            // ===============================================================================================
            customRelic.itemName = Lang.Get(3, ItemID * 2);
            customRelic.description = Lang.Get(3, (ItemID * 2) + 1);

            customRelic.rarity = 5; // Mengunci kualitas pada Tier Oranye / Legendaris
            customRelic.canUpgradeToTier = ItemRarity.Legendary_5;
            customRelic.basePrice = baseRelic.basePrice * 5f; // Kompensasi nilai ekonomi tinggi
            customRelic.craftable = true;
            customRelic.craftingYield = 1;

            // Formula Resep Penggabungan: 3 Relik Kuno biasa (ID 24)
            customRelic.craftingMaterials = new List<CraftMaterial>
            {
                new CraftMaterial
                {
                    itemID = AncientRelicMaterialId,
                    quantity = 3
                }
            };

            // Suntikkan item yang berhasil dirakit ke dalam daftar list global engine game
            list.Add(customRelic);
        }

        public const int ItemID = 31031990;
        public const int AncientRelicMaterialId = 24;
    }
}