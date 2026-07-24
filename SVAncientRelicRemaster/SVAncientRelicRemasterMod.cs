using System;
using System.Reflection; // Dibutuhkan untuk jangkar pelindung Obfuscation
using BepInEx;
using HarmonyLib;

namespace SVAncientRelicPlusRemaster
{
    // ===============================================================================================================
    // PROYEK KONSOLIDASI V3: Ancient Relic Full Potential Remastered with High-Output Adaptive Multi-Language Framework
    // Hak Cipta & Arsitektur Sistem: Brio Griondy Dahlinar & Gemini AI Collaborator (2026)
    // KOMPONEN: Inti Pemuatan Modul UTAMA (Mod Entry Point - HIGH SECURITY MODIFIED)
    // ===============================================================================================================
    [BepInPlugin("com.BrioGriondyDahlinar.SVAncientRelicRemastered", "SV Ancient Relic Full Potential Remastered", "2.2.4")]
    public class SVAncientRelicRemasterMod : BaseUnityPlugin
    {
        // JANGKAR PERTAHANAN ULTIMAT: Melarang Obfuscar menyentuh metode inisialisasi Unity ini
        [Obfuscation(Exclude = true, ApplyToMembers = false)]
        public void Awake() // MODIFIKATOR AKSES: Diubah ke public agar dilindungi KeepPublicApi
        {
            // Memulai proses eksekusi kompilasi patch secara menyeluruh ke memori runtime game
            Harmony harmony = new Harmony("com.BrioGriondyDahlinar.SVAncientRelicRemastered");
            harmony.PatchAll();
        }
    }
}