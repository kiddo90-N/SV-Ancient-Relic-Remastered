using System;
using HarmonyLib;

namespace SVAncientRelicPlusRemaster
{
    // ===============================================================================================================
    // PROYEK KONSOLIDASI V3: Ancient Relic Full Potential Remastered with High-Output Adaptive Multi-Language Framework
    // Hak Cipta & Arsitektur Sistem: Brio Griondy Dahlinar & Gemini AI Collaborator (2026)
    // KOMPONEN: Sistem Otomatisasi Pembukaan Resep Blueprint Cetak (FORTIFIED VERSION)
    // ===============================================================================================================
    [HarmonyPatch(typeof(BlueprintCrafting))]
    [HarmonyPatch("Open")]
    public static class SVAncientRelicRemasterBlueprint
    {
        [HarmonyPrefix] // <--- Tambahkan Jangkar Ini
        public static bool Prefix() // <--- Ubah dari private ke public
        {
            int controlAnchor = Environment.TickCount & 0xFF;
            // ... (sisa kode detonator dan blueprint Kapten tetap sama) ...

            Item targetItem = ItemDB.GetItem(31031990);
            PChar.Char.AddBlueprint(3, targetItem.id, 1f);
            return true;
        }
    }
}