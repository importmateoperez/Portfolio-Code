# 🌐 Hybrid-Cloud Infrastructure & Homelab Operations

## 📌 Overview
This repository serves as the **Source of Truth** for my hybrid-cloud environment. It contains the Infrastructure as Code (IaC), configuration management, and automation scripts used to maintain a high-availability homelab and Azure footprint.

### 🎯 The Mission
To demonstrate enterprise-grade systems administration by treating my home network as a production environment—prioritizing **security** (VLAN segmentation), **automation** (Bash/Terraform), and **secure remote accessibility** (Tailscale).

---

## 🏗️ Architecture Design
My lab is built on a multi-tier network architecture managed by a custom **OPNsense** firewall.



### 🖥️ Hardware Inventory
* **Edge Router:** Dell Optiplex (OPNsense)
* **Managed Switching:** TP-Link managed switch utilizing 802.1Q VLAN segmentation.
* **Virtualization:** Proxmox VE (Windows Server 2022 AD DS & Windows 11).
* **Container Ops:** * **Fedora 42 (Podman)** on Dell Inspiron 2015 – Hosting Nextcloud (Prod/Dev).
    * **Debian (Docker)** on Samsung 2012 – Hosting Apache2 Web Server (Prod/Dev).

---

## 🚀 Key Projects & Implementations

### 1. Secure and Encrypted Connectivity (Tailscale)
Implemented a **Zero-Trust Mesh VPN** using Tailscale to allow secure, encrypted access to the Proxmox and OPNsense GUIs from any location without exposing management ports to the public internet.

### 2. Linux Containerization (Podman vs. Docker)
Managed and hardened a dual-container environment. I specifically opted for **Podman** on Fedora for Nextcloud instances to leverage **rootless containers**, significantly enhancing the security posture of personal data.

### 3. Windows Server 2022 & Proxmox VE
Deployed and configured **Windows Server 2022** as an Active Directory Domain Controller (AD DS). Managed Group Policy Objects (GPOs), user permissions, and secure Windows 11 client integration within a virtualized Proxmox environment.

### 4. OPNsense Firewall Configuration
Engineered a dedicated OPNsense firewall on Dell hardware to serve as the primary gateway. Implemented **L3/L4 firewall rules** to harden the network and prevent unauthorized lateral movement between VLANs.

### 5. Azure Cloud Administration
Utilized **Bicep and Terraform** for rapid prototyping of Azure environments to deploy secure, scalable resources. Performed core Azure administration tasks, including cost management, performance monitoring, and availability tracking.

---

## 🛠️ Skills Demonstrated

* **Disaster Recovery:** Engineered Bash-based backup pipelines for PostgreSQL/MariaDB databases and container volumes. Implemented full-disk system imaging to ensure rapid recovery in the event of hardware failure.
* **Automated Reporting:** Developed a custom telemetry system using **Bash and SMTP** to deliver daily health reports, backup status (Success/Failure), and storage metrics directly to my inbox.
* **Windows Server 2022 Administration:** Expert management of Active Directory (AD DS), Group Policy Objects (GPOs), and Windows 11 client provisioning.
* **Linux Administration:** Full lifecycle management including OS installation, patching, kernel hardening, and package management across **Fedora (DNF)** and **Debian (APT)**.
* **Virtualization:** Proxmox VE administration, including VM resource allocation and snapshot-based backup strategies.
* **Networking:** VLAN Tagging, L3/L4 Firewall Rules, Mesh VPN, and Dynamic DNS (DDNS).
* **Security:** Identity Management (AD), Rootless Containers, and SSH Key Authentication.
* **DevOps:** Version control via Git, CI/CD methodology, and Infrastructure as Code (IaC).
