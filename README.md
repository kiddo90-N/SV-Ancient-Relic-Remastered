# 🌌 SV Ancient Relic Full Potential Remastered

[![Nexus Mods](https://img.shields.io/badge/Nexus%20Mods-Download-orange?style=for-the-badge&logo=nexusmods)](https://www.nexusmods.com/starvalor/mods/XXXX)
[![License: GPL v3](https://img.shields.io/badge/License-GPLv3-blue.svg?style=for-the-badge)](https://www.gnu.org/licenses/gpl-3.0)
[![Framework](https://img.shields.io/badge/BepInEx-5.4+-green?style=for-the-badge)](https://github.com/BepInEx/BepInEx)

## 🇲🇨 Deskripsi Proyek (Indonesian)
Modul konsolidasi V3 untuk game *Star Valor*. Mod ini meng-overhaul material **Ancient Relic Tier 4 (ID 24)** menjadi **Ancient Relic Full Potential Remastered (ID 31031990)** berkategori Legendaris (Tier 5). Dilengkapi dengan kerangka kerja **Native Multi-Language Interceptor (11 Bahasa)** dan arsitektur pengaman internal runtime.

## 🇬🇧 Project Overview (English)
Consolidation V3 module for *Star Valor*. Overhauls the vanilla **Tier 4 Ancient Relic (ID 24)** into the Legendary **Ancient Relic Full Potential Remastered (ID 31031990)**. Built with a robust **Native Multi-Language Interceptor (11 Languages)** framework and runtime protection logic.

---

## 🏗️ Technical Architecture Highlights
* **Harmony Database Injection:** `ItemDB.LoadDatabaseForce` Postfix hook for dynamic item instantiation.
* **Blueprint Auto-Unlock:** `BlueprintCrafting.Open` Prefix interceptor for seamless recipe acquisition.
* **Native Runtime Localization:** Zero-dependency string interception supporting EN, DE, FR, PL, BR, ES, IT, VN, RU, ZH, and KO via UTF-8 encoding.
* **Robust Fallbacks:** Memory-safe array reflection and PlayerPrefs fallback chains to eliminate Language Errors.

---

## 📜 Intellectual Property & Attribution
* **Authors:** Brio Griondy Dahlinar (2026)
* **License:** Licensed under GNU General Public License v3.0.