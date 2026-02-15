Overview

This repository serves as the Source of Truth for my hybrid-cloud environment. It contains the Infrastructure as Code (IaC), configuration management, and automation scripts used to maintain a high-availability homelab and Azure footprint.

The Mission

To demonstrate enterprise-grade systems administration by treating my home network as a production environment—prioritizing security (VLAN segmentation), automation (Bash/Terraform), and remote accessibility (Tailscale).

Architecture Design

My lab is built on a multi-tier network architecture managed by a custom OPNsense firewall.

Hardware Inventory

Edge Router: Dell Optiplex (OPNsense)

Managed Switching: TP Link managed switch utilizing VLAN segmentation

Virtualization: Proxmox VE (Windows Server 2022 AD DS & Win11)

Container Ops: Fedora 42 (Podman) on Dell Inspiron 2015 - Nextcloud server Prod/Dev
  Debian (Docker) on Samsung 2012 - Apache2 web server hosting Prod/Dev

Key Projects & Implementations
1. Secure and Encrypted Connectivity with Tailscale
  I implemented a Zero-Trust Mesh VPN using Tailscale to allow secure, encrypted access to the Proxmox and OPNsense GUIs from anywhere in the world without exposing ports to the public internet.

2. Linux Containerization (Podman vs. Docker)
  I managed, hardened, and implemented a dual-container environment. I specifically chose Podman on Fedora for my Nextcloud instances to leverage rootless containers, enhancing the security posture of my personal data.

3. Windows Server 2022 Proxmox VE
  I deployed and configured Windows Server 2022 as an Active Directory Domain Controller (AD DS). Managed Group Policy Objects (GPOs), user permissions, and secure Windows 11 client integration.

4. OPNsense Firewall Configuration
  I engineered a dedicated OPNsense firewall on Dell hardware to serve as the primary gateway, implementing L3/L4 firewall rules to harden the network against external threats.

5. Azure Cloud Administration
  I Used Bicep and Terraform for rapid prototyping of Azure environments in order to understand and create secure resources. I also performed Azure admin tasks such as monitoring resource costs, performance, and availability.

Skills Demonstrated

Disaster Recovery: Engineered Bash-based backup pipelines for PostgreSQL/MariaDB databases and container volumes across Fedora and Debian nodes. Disk wide backups images also made for entire system recovery

Automated Reporting: Developed a custom telemetry system using Bash and SMTP to deliver daily health reports, backup status (Success/Failure), and storage metrics directly to my inbox

Windows Server 2022 Administration: Active Directory (AD DS) management, Group Policy Objects (GPO), and Windows 11 client provisioning

Linux Administration: OS installation/patching, kernel hardening, and package management across Fedora (DNF) and Debian (APT) distributions

Virtualization: Proxmox VE management, VM resource allocation, and snapshot-based backup strategies

Networking: VLAN Tagging, Firewall Rules (L3/L4), VPN Mesh, Dynamic DNS

Security: Identity Management (AD), Rootless Containers, SSH Key Auth

DevOps: Git, CI/CD mindset, Infrastructure as Code
