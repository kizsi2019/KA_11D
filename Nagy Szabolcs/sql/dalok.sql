SELECT lista.ev, dalok.cim, eloadok.nev
  FROM lista, dalok, eloadok
  WHERE lista.ev = '2010' AND lista.helyezes = 1
      AND lista.dalid = dalok.dalid AND dalok.eloadoid = eloadok.eloadoid;

  SELECT lista.ev, dalok.cim, eloadok.nev FROM lista, dalok, eloadok WHERE lista.ev = '2010' AND lista.helyezes <= 3 AND lista.dalid = dalok.dalid AND dalok.eloadoid = eloadok.eloadoid;

  SELECT dalok.cim, eloadok.nev FROM lista, dalok, eloadok WHERE eloadok.nev LIKE 'b%' AND lista.dalid = dalok.dalid AND dalok.eloadoid = eloadok.eloadoid;