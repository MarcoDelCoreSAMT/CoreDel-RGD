Gantt di test
```mermaid
gantt
    title CoreDel-RGD
    dateFormat YYYY-MM-DD
    section Pianificazione
    Analisi e requisiti      :done, p1, 2026-09-01, 10d
    Progettazione            :done, p2, after p1, 7d
    section Sviluppo
    Applicativo Unity        :active, s1, after p2, 30d
    Test                     :s2, after s1, 7d
    section Documentazione
    Diari di lavoro          :d1, 2026-09-01, 60d
    Documentazione finale    :d2, after s1, 14d
```
