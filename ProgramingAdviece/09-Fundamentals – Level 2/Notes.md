# Course 09 – Network & System Fundamentals (Level 2)

## 📌 Overview
This course built my understanding of how the Internet, networks, servers, and web systems actually work behind the scenes.  
It changed the way I see backend development by connecting theory with real-world infrastructure.

---

# 1️⃣ Servers

## What is a Server?
A server is a computer (hardware or software) that shares resources or services with other computers over a network.

### Server vs Regular Computer
- Higher reliability and dependability
- Can run continuously for years
- Higher performance
- Lower long-term maintenance cost

### Types of Servers
- Web Server
- Application Server
- Database Server
- File Server
- Mail Server
- Printing Server
- Image Server
- Game Server
- VoIP Server

### Server Forms
- Tower
- Rack
- Blade

---

# 2️⃣ How Data is Transferred

Data is divided into small parts called **Packets**.

- Large data is split into packets.
- Packets are sent separately.
- Packets are reassembled at the destination.
- Tools like Download Accelerator work using packet division.

---

# 3️⃣ TCP/IP Model

## TCP (Transmission Control Protocol)
- Divides messages into packets.
- Ensures packets are delivered correctly.
- Reassembles packets in the correct order.
- Manages communication channels between applications.

## IP (Internet Protocol)
- Defines rules for addressing and routing data.
- Every device has a unique IP address.

### IP Versions
- IPv4 → 32 bits (4 bytes)
- IPv6 → 128 bits (16 bytes)

### IP Types
- Public IP (given by ISP)
- Private IP (used inside local network)
- Static IP (manual, fixed)
- Dynamic IP (assigned automatically via DHCP)

---

# 4️⃣ ISP (Internet Service Provider)

A company that provides internet access to individuals and organizations.

---

# 5️⃣ Network Devices

## Modem
- Converts analog signals to digital signals.
- Connects your network to the internet line.

## Router
- Connects multiple devices.
- Distributes internet using wired or wireless.
- Works with the same protocol inside the network.

## Gateway
- Similar to router.
- Can translate between different protocols or formats.

---

# 6️⃣ DHCP

Dynamic Host Configuration Protocol.

- Automatically assigns IP addresses.
- Provides related configuration information.
- Works as client-server model.

---

# 7️⃣ NAT (Network Address Translation)

- Maps private IP addresses to a public IP.
- Implemented in router or gateway.
- Uses NAT table to track connections.
- Allows multiple devices to share one public IP.

---

# 8️⃣ Ports & Sockets

- Port = Number assigned to identify connection endpoint.
- Socket = IP Address + Port

Example:
192.168.1.1:23

Ports help determine which application should receive the data.

---

# 9️⃣ Subnet & CIDR

Subnetting divides a network into smaller networks for:

- Better routing
- Better security

### CIDR Classes
- Class A → /8 → 255.0.0.0
- Class B → /16 → 255.255.0.0
- Class C → /24 → 255.255.255.0

---

# 🔟 MAC Address

Media Access Control address.

- Unique hardware identifier.
- Used inside local network.
- IP routes to the network.
- MAC delivers to the specific device.

---

# 1️⃣1️⃣ Privacy & IP Exposure

Your IP address can reveal:

- Location
- ISP
- Online activity patterns

Who can track it:
- Authorities
- Advertisers
- Employers
- Cybercriminals

## Protection Methods
- VPN (Virtual Private Network)
  - Encrypted tunnel
  - Changes IP address
  - Masks geolocation

---

# 1️⃣2️⃣ Internet vs World Wide Web

Internet:
- Network of networks
- Infrastructure
- No single owner

WWW:
- Collection of websites
- Runs on top of the Internet

Internet = Infrastructure  
WWW = Content layer

---

# 1️⃣3️⃣ Browser & Web Communication

Browser:
- Application used to access the web.
- Sends HTTP requests using URL.
- Interprets and renders webpage.

---

# 1️⃣4️⃣ HTTP & HTTPS

HTTP:
- Protocol used to transfer data.

HTTPS:
- HTTP with encryption.
- Uses SSL/TLS.
- Secures communication.

---

# 1️⃣5️⃣ Domain & DNS

## Domain Name
- Human-readable name linked to IP address.

## DNS
- Translates domain names into IP addresses.
- Works like a phonebook of the internet.

## Subdomain
Example:
- egypt.example.com
- jordan.example.com

---

# 1️⃣6️⃣ URL Structure

URL includes:
- Protocol (http / https / ftp)
- Subdomain
- Domain name
- Top-level domain
- Port (optional)
- Path
- Query parameters
- Fragment

---

# 1️⃣7️⃣ FTP

File Transfer Protocol.

- Upload/download files.
- Transfer multiple files.
- Resume transfers.
- Schedule transfers.
- No size limit.

---

# 1️⃣8️⃣ API

Application Programming Interface.

- Allows systems to communicate.
- Web API enables communication over HTTP.

---

# 1️⃣9️⃣ Data Formats

## XML
- Stores and transports data as text.
- Platform independent.
- Can be transformed into other formats.

## JSON
- Lightweight data format.
- Easier to read and faster than XML.

---

# 2️⃣0️⃣ GUID / UUID

- 128-bit unique identifier.
- Represented as hexadecimal.
- Used to uniquely identify records or objects.

---

# 2️⃣1️⃣ 3-Tier Architecture

Presentation Layer:
- UI (HTML, GUI)

Business Layer:
- Business logic
- Application rules
- Calculations

Data Layer:
- Database
- Stored procedures
- Data persistence

---

# 2️⃣2️⃣ Business Intelligence (BI)

BI transforms raw data into valuable information.

Key Questions:
- What happened?
- What is happening?
- Why did it happen?
- What will happen?
- What should happen?

"If you cannot measure it, you cannot manage it."

---

# 2️⃣3️⃣ Security (Simple Definition)

Security means:
- Protecting data
- Protecting systems
- Controlling access
- Preventing unauthorized actions

---

# 💡 How This Course Changed My Thinking

Before this course, I saw web development as just writing code.

After this course:
- I understand how requests travel.
- I understand how servers communicate.
- I understand how data is routed.
- I understand the role of ports, protocols, and architecture.
- I see backend development as part of a larger infrastructure system.

This foundation supports my backend journey and helps me build systems with better awareness of networking, security, and architecture.

---