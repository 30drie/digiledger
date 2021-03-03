# digiledger
This repository is the start of an open source Digital Ledger System.

## Purpose
Why is this project created?
I work both for a company, but have small projects on the side. As it doesn't make any money (yet ;) ), I wanted everything as cheap as possible.
For the Financial Administration, I found WaveApps. It was free (only when paying the invoices via WaveApps or when doing Payroll, there was fee) and it had some nice features, including scanning and saving of PDF's.
WaveApps decided to pull back there global footprint to only serve North America (ie. US + Canada). No new customers outside the US and no security for current users in other parts of the world. As a customer myself, not living in the US, the future of WaveApps is uncertain.

This is where DigiLedger comes in. I've decided to do this as open source project. Everyone can use it as they like as long as respecting the license.

The second functionality is to use DigiLedger as household administration system. The differences in a business ledger or a personal ledger is not that big. Mainly business have VAT and write offs. Both have income and costs which is divided in different categories.

I am not a bookkeeper or an accountant so some stuff I have to figure out. Also, the basis is my personal preferences and based on the Dutch tax system. But it should still be viable.

## Options to use
1. Host it yourself. It requires some technical knowledge and other stuff and you have to pay for hosting and everything else yourself.
2. Share the hosting through 30Drie. The goal is to have a monthly subscription of €1 with full functionality. This should make the system available for anyone.

## Technical stuff
1. Base will be C# on .NET 5 or newer.
2. We will use Blazor as web application.
3. SQL Server on Azure
4. Azure's Computer Vision API to scan invoices and bills.

In a later stage we might move to Blazor WebAssembly and perhaps Blazor Hybrid.
