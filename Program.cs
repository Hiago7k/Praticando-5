using Praticando_5;

Analista analista = new Analista("Analista de Sistemas");
Docente docente = new Docente("Docente de Matematica");
Certificado cert1 = new Certificado(analista);
Certificado cert2 = new Certificado(docente);

cert1.AdicionarCertificado();
cert2.AdicionarCertificado();
