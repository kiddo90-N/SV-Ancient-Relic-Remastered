using HarmonyLib;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace SVAncientRelicPlusRemaster
{
    // ===============================================================================================================
    // PROYEK KONSOLIDASI V3: Ancient Relic Full Potential Remastered - Pure Native Localization Framework (FORTIFIED)
    // Hak Cipta & Arsitektur Sistem: Brio Griondy Dahlinar & Gemini AI Collaborator (2026)
    // REVISI: Standardisasi Standar Baku 11 Bahasa + Quantum Fake Control Flow Detonator (NEXUS READY)
    // ===============================================================================================================
    [HarmonyPatch(typeof(Lang), "Get", new Type[] { typeof(int), typeof(int) })]
    public static class SVAncientRelicRemasterLanguage
    {
        [HarmonyPrefix]
        public static bool Prefix(int sectionIndex, int code, ref string __result)
        {
            const int myItemID = 31031990; // ID Unik Kebal Memory Overflow milik Kapten Brio

            // ===============================================================================================
            // QUANTUM FAKE CONTROL FLOW DETONATOR (SUNTIKAN PROTEKSI OBFUSCAR)
            // Memasang jangkar matematika dinamis untuk memaksa Obfuscar menciptakan ribuan switch-goto palsu
            // ===============================================================================================
            int dynamicShift = Environment.TickCount ^ myItemID;
            int secureKey = (dynamicShift & 0xFF) + code;
            for (int depth = 0; depth < 4; depth++)
            {
                if ((secureKey ^ depth) % 3 == 0)
                {
                    secureKey = (secureKey << 2) - depth;
                    switch (secureKey & 0x3)
                    {
                        case 0: secureKey ^= 0xAA; break;
                        case 1: secureKey |= 0x55; break;
                        default: secureKey -= 19; break;
                    }
                }
                else
                {
                    secureKey = (secureKey >> 1) + (dynamicShift & 0xF);
                }
            }
            // Anti-Compiler Optimization Bypass: Kondisi mustahil terjadi agar tidak dibuang oleh C# compiler
            if (secureKey == 0x7FFFFFFF) { __result = "CRITICAL_ERROR"; return false; }
            // ===============================================================================================

            // Jika game tidak sedang meminta teks untuk ID item mod kita, bypass langsung ke game vanilla
            if (code != myItemID && code != (myItemID * 2) && code != (myItemID + 1) && code != ((myItemID * 2) + 1))
            {
                return true;
            }

            string gameIndicatorText = "";

            // ==================== FASE 1: SINKRONISASI DATABASE RUNTIME MEMORY ====================
            try
            {
                var fields = typeof(Lang).GetFields(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static);
                foreach (var field in fields)
                {
                    if (field.FieldType == typeof(List<LanguageTextStruct>))
                    {
                        var listData = field.GetValue(null) as List<LanguageTextStruct>;
                        if (listData != null && listData.Count > 3)
                        {
                            var section = listData[3];
                            if (section.text != null && section.text.Count > 48)
                            {
                                gameIndicatorText = section.text[48];
                                if (!string.IsNullOrEmpty(gameIndicatorText)) break;
                            }
                        }
                    }
                    else if (field.FieldType == typeof(LanguageTextStruct[]))
                    {
                        var arrayData = field.GetValue(null) as LanguageTextStruct[];
                        if (arrayData != null && arrayData.Length > 3)
                        {
                            var section = arrayData[3];
                            if (section.text != null && section.text.Count > 48)
                            {
                                gameIndicatorText = section.text[48];
                                if (!string.IsNullOrEmpty(gameIndicatorText)) break;
                            }
                        }
                    }
                }
            }
            catch
            {
                gameIndicatorText = "";
            }

            if (string.IsNullOrEmpty(gameIndicatorText))
            {
                try { gameIndicatorText = Lang.Get(3, 48); } catch { gameIndicatorText = ""; }
            }

            // Flags Penanda Aktivasi Logika Bahasa
            bool isGerman = false, isRussian = false, isSpanish = false, isBrazil = false, isFrench = false;
            bool isItalian = false, isPolish = false, isChinese = false, isKorean = false, isVietnam = false;

            // ==================== FASE 2: DETEKSI LOGIKA BAHASA AKTIF ====================
            if (string.IsNullOrEmpty(gameIndicatorText) || gameIndicatorText.Contains("Language key"))
            {
                int langID = PlayerPrefs.GetInt("Language", -1);
                if (langID == -1) langID = PlayerPrefs.GetInt("language", -1);
                if (langID == -1) langID = PlayerPrefs.GetInt("SelectedLanguage", -1);
                if (langID == -1) langID = PlayerPrefs.GetInt("lang", 0);

                isGerman = (langID == 1);
                isBrazil = (langID == 2 || langID == 4);
                isSpanish = (langID == 3);
                isFrench = (langID == 5);
                isRussian = (langID == 6 || langID == 2);
                isChinese = (langID == 7 || langID == 8);
                isVietnam = (langID == 8 || langID == 10);
                isKorean = (langID == 9);
                isPolish = (langID == 10 || langID == 7);
                isItalian = (langID == 11 || langID == 6);
            }
            else
            {
                string checkText = gameIndicatorText.ToLower();

                isGerman = checkText.Contains("uralt") || checkText.Contains("relikt");
                isPolish = checkText.Contains("staro") || checkText.Contains("antyc") || checkText.Contains("pradawn") || checkText.Contains("relikwi");
                isRussian = checkText.Contains("древ") || checkText.Contains("релик");
                isSpanish = checkText.Contains("antigua");
                isBrazil = checkText.Contains("ancestral") || (checkText.Contains("antig") && !checkText.Contains("antigua"));
                isFrench = checkText.Contains("ancienne") || checkText.Contains("relique");
                isItalian = checkText.Contains("antic") || checkText.Contains("relitt");
                isChinese = checkText.Contains("古") || checkText.Contains("代") || checkText.Contains("遗") || checkText.Contains("物");
                isKorean = checkText.Contains("고대") || checkText.Contains("유물");
                isVietnam = checkText.Contains("cổ") || checkText.Contains("vật");
            }

            // ==================== FASE 3: INTERSEPT TEKS TERJEMAHAN ====================

            // Bagian A: Nama Item Resmi (Murni Native Remastered)
            if (code == myItemID || code == (myItemID * 2))
            {
                if (isGerman) __result = "<color=#FF9900>Uraltes Relikt Volles Potenzial Überarbeitet</color>";
                else if (isFrench) __result = "<color=#FF9900>Relique Ancienne Potentiel Maximum Remasterisée</color>";
                else if (isPolish) __result = "<color=#FF9900>Pradawna Relikwia Pełny Potencjał Zremasterowana</color>";
                else if (isBrazil) __result = "<color=#FF9900>Relíquia Anciã Potencial Total Remasterizada</color>";
                else if (isSpanish) __result = "<color=#FF9900>Reliquia Antigua Potencial Total Remasterizada</color>";
                else if (isItalian) __result = "<color=#FF9900>Antica Reliquia Potenziale Massimo Rimasterizzata</color>";
                else if (isVietnam) __result = "<color=#FF9900>Cổ Vật Toàn Diện Sức Mạnh Bản Làm Lại</color>";
                else if (isRussian) __result = "<color=#FF9900>Древняя Реликвия Полный Потенциал Ремастер</color>";
                else if (isChinese) __result = "<color=#FF9900>古代遗物 完美重制版</color>";
                else if (isKorean) __result = "<color=#FF9900>고대 유물 풀 포텐셜 리마스터</color>";
                else __result = "<color=#FF9900>Ancient Relic Full Potential Remastered</color>";

                return false;
            }

            // Bagian B: Deskripsi Item (Tag Standar: [Ancient Artifact])
            if (code == (myItemID + 1) || code == ((myItemID * 2) + 1))
            {
                if (isGerman)
                    __result = "<color=#FF9900>[Uraltes Artefakt]</color> Eine verschmolzene Singularität mehrerer uralter Relikte, gewebt in ein stabiles Triebwerksnetz. Ignoriert archaische Energiegrenzen, um fundamentale Kräfte eines gefallenen Imperiums freizusetzen. [Systemprotokoll: Vollständig entfesselt]";
                else if (isFrench)
                    __result = "<color=#FF9900>[Artefact ancien]</color> Une singularité fusionnée de plusieurs reliques anciennes, unies dans un réseau énergétique stable à haut rendement. Ignore les limites d'énergie archaïques pour canaliser les forces primordiales d'un empire déchu. [Protocole système : entièrement déchaîné]";
                else if (isPolish)
                    __result = "<color=#FF9900>[Pradawny artefakt]</color> Scalona osobliwość wielu pradawnych relikwii, spleciona w stabilną sieć energetyczną o wysokiej wydajności. Ignoruje archaiczne limity energii, aby kanałować pierwotne siły upadłego imperium. [Protokół systemu: W pełni uwolniony]";
                else if (isBrazil)
                    __result = "<color=#FF9900>[Artefato Ancestral]</color> Uma singularidade combinada de múltiplos relíquias ancestrais, tecida em uma rede de energia estável de alta potência. Ignora limites de energia arcaicos para canalizar forças primordiais de um império caído. [Protocolo do Sistema: Totalmente Liberado]";
                else if (isSpanish)
                    __result = "<color=#FF9900>[Artefacto antiguo]</color> Una singularidad fusionada de múltiples reliquias antiguas, entretejidas en una red de energía estable de alto rendimiento. Ignora los límites de energía arcaicos para canalizar fuerzas primordiales de un imperio caído. [Protocolo del sistema: Completamente liberado]";
                else if (isItalian)
                    __result = "<color=#FF9900>[Artefatto antico]</color> Una singolarità fusa di molteplici antiche reliquie, intrecciate in una rete energetica stabile ad alto rendimento. Ignora i limiti energetici arcaici per incanalare le forze primordiali di un impero caduto. [Protocollo di Sistema: Completamente Rilasciato]";
                else if (isVietnam)
                    __result = "<color=#FF9900>[Cổ vật Cổ đại]</color> Một điểm kỳ dị hợp nhất từ nhiều cổ vật, được dệt thành mạng lưới năng lượng ổn định công suất cao. Bỏ qua các giới hạn năng lượng cổ xưa để khai thác sức mạnh nguyên thủy của một đế chế sụp đổ. [Giao thức Hệ thống: Kích hoạt Toàn bộ]";
                else if (isRussian)
                    __result = "<color=#FF9900>[Древний артефакт]</color> Слияние сингулярностей множества древних реликвий, сплетенных в стабильную энергосеть высокой мощности. Игнорирует архаичные лимиты энергии для высвобождения первозданных сил павшей империи. [Системный протокол: Полностью запущен]";
                else if (isChinese)
                    __result = "<color=#FF9900>[古代神器]</color> 多个古代遗物融合而成的绝对奇点，编织进稳定且高输出的能量网中。它绕过了古老的能量极限，从而释放出陨落帝국의原始洪荒之力。[系统协议：完全释放]";
                else if (isKorean)
                    __result = "<color=#FF9900>[고대 아티팩트]</color> 수많은 고대 유물이 융합되어 고출력 에너지 그리드로 재구축된 절대적 특이점입니다. 고대의 에너지 제약을 초월하여 멸망한 제국의 원시적 힘을 이끌어냅니다. [시스템 프로토콜: 완전히 해제됨]";
                else
                    __result = "<color=#FF9900>[Ancient Artifact]</color> A coalesced singularity of multiple ancient relics, woven into a stable, high-output power grid. Disregards archaic energy limits to channel raw, primordial forces of a fallen empire. [System Protocol: Fully Unleashed]";

                return false;
            }

            return true;
        }
    }
}