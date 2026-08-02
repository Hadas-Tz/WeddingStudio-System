# 🌸 Wedding Studio Management System

WeddingStudio-System — A full desktop management system for “Tzof” Bridal Studio

This system was developed as a final project and is designed to manage the full operational workflow of a bridal studio:
customer management, dress catalog, appointments, accessories, feedback, messages, and service processes — all in one place.

The system is built using a 3‑Tier architecture, ensuring clear separation between layers:
Presentation (UI), Business Logic (BLL), and Data Access (DAL).

## Admin Interface (secured):  

Manage customers, orders, dresses, accessories, feedback, messages, statuses, and more.

Customer Interface:  
View dress and accessory catalog, authenticate using ID number, submit feedback, rate service, and view the “About” page.

Message Management:  
Send messages to the studio manager via MessageManager and view/update message status through FinalProject.

Inventory Management:  
Dresses, sizes, accessories, categories, prices, and images.

## 🧩 Solution Structure — The Four Projects

🎀 FinalProject — Main WPF Application
The primary studio interface: managing customers, dresses, orders, accessories, messages, and catalog views.

💬 MessageManager — Customer Messaging App
A lightweight WPF client for sending messages to the manager via the WCF service.

🛠 WcfServiceLibrary1 — WCF Service
Implements the system’s service operations: retrieving messages, adding new messages, updating status, generating new message codes, and more.

🖥 MyHost — Service Host
A small WPF application that hosts the WCF service and exposes the endpoints for the clients.

## 🛠 Technologies & Architecture

WPF (C#) — User Interface

WCF — Communication between client and service

Entity Framework — ORM

SQL Server / LocalDB — Database

3‑Tier Architecture — Clear separation of layers

Visual Studio 2022

.NET Framework 4.7.2

## 🗂 Architectural Structure

Presentation Layer:  
FinalProject (WPF), MessageManager (WPF)

Business Logic Layer:  
WcfServiceLibrary1 (WCF Service)

Data Access Layer:  
Entity Framework + SQL Server (MyDBEntities3, MessageDBEntities)

## 📦 Development Environment & Requirements

Visual Studio 2022

.NET Framework 4.7.2

SQL Server / LocalDB

## ▶️ How to Run the System

Open the solution in Visual Studio.

Ensure all connection strings are correctly configured.

Run MyHost first to start the WCF service.

Run FinalProject or MessageManager.

Build → Run.

## 🌟 Summary

WeddingStudio-System is a complete desktop solution for managing a bridal studio,
featuring a professional architecture, WCF services, a rich database, and a friendly, intuitive user interface.

## 📞 Contact

Feel free to reach out via my LinkedIn profile:
https://www.linkedin.com/in/hadas-tzuberi-62803b424/
