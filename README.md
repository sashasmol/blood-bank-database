# Blood Bank Database - Design Document
#### ERD
<img src= "Database ERD.png">

#### Schema
`Patients (pid: integer)`<br />
`Donors (did: integer)`<br />
`Blood Blank (b_name: string, b_address: string, b_num: string)`<br />
`Profile (SSN: integer, p_name: string, b_group: string, med_report: string, addr: string, num:string)`<br />
`Donates(did: integer, b_name: string)`<br />
`Collects(pid: integer, b_name:string)`

#### Queries and Functional Dependencies
Patient (pid) P → S, in BCNF Form (SP)<br />
Donor (did) D → S, in BCNF Form (SD)<br />
Blood Blank (b_name, b_address, b_num) N → AX (NAX)<br />
     N → AX is not in BCNF<br />     
     N → AX is in 3NF because there are no transitive dependencies in this case <br />
Profile(SSN, p_name, b_group, med_report, addr, num) <br />
     S → NBREY (SNBREY)<br />
     S → NBREY is not in 3NF because it has transitive dependencies (P → S and D→ S and S → NBREY)<br />
     Therefore, S → NBREY is in 2NF<br />
     In order to put this back into 3NF, transitive dependencies must be removed and be functionally dependent on the key → R1 = {P, D, S} and R2 = {S, N, B,                            
     R, E Y}.<br />
Donates(did, b_name): No FDs, in BCNF Form <br />
Collects(pid, b_name): No FDs, in BCNF Form
