# 🧩 PokePage

PokePage é uma aplicação fullstack para catalogação de Pokémons com processamento assíncrono de dados, persistência local e geração de insights utilizando IA.

O projeto foi concebido como laboratório prático de engenharia de software, com foco em arquitetura desacoplada, mensageria e integração com LLM.

---

## 🎯 Objetivos

- Consumir dados de uma API pública de Pokémons  
- Processar e persistir os dados localmente  
- Utilizar mensageria para desacoplamento  
- Disponibilizar catálogo consultável  
- Gerar insights automáticos via IA  
- Explorar arquitetura escalável de forma controlada  

---

## 🏗️ Arquitetura Geral

A aplicação é composta por:

- **Frontend**
- **API Backend**
- **Fila de Mensagens**
- **Worker**
- **Banco de Dados**
- **Módulo de IA**

### Fluxo simplificado

1. API solicita sincronização.
2. Mensagem é publicada na fila.
3. Worker consome a mensagem.
4. Dados são processados e persistidos.
5. Frontend consulta a API.
6. IA gera insights a partir dos dados armazenados.

---

## 🛠️ Stack Tecnológica

### Frontend
- React
- TypeScript

### Backend
- ASP.NET Web API

### Banco de Dados
- MongoDB

### Mensageria
- RabbitMQ

### Cache (Evolução futura)
- Redis

### Inteligência Artificial
- Microsoft Agent Framework
- Gemini (LLM)

### Infraestrutura
- Docker

---

## 📦 Componentes

### Frontend
- Página de catálogo
- Filtros por tipo
- Visualização de atributos
- Dashboard de insights
- Chat de consulta com IA

### API (ASP.NET)
Responsável por:
- Expor endpoints REST
- Publicar mensagens na fila
- Consultar MongoDB
- Integrar com módulo de IA

### RabbitMQ
Utilizado para:
- Desacoplar sincronização de dados
- Controlar fluxo de processamento
- Permitir escalabilidade futura
- Experimentação com mensageria

### Worker
Responsável por:
- Consumir mensagens
- Buscar dados na API externa
- Processar e normalizar dados
- Atualizar MongoDB

### MongoDB
Armazena:
- Pokémons
- Tipos
- Estatísticas básicas

### Redis (Planejado)
Uso futuro para:
- Cache de consultas frequentes
- Cache de respostas da IA
- Redução de carga no banco

### Módulo de IA
Responsável por:
- Identificar tipos predominantes
- Gerar insights automáticos
- Permitir consultas em linguagem natural
- Alimentar dashboard analítico

---

## 🧠 Justificativa Arquitetural

Apesar de o projeto não exigir alta complexidade, tecnologias como RabbitMQ e Redis são utilizadas com propósito educacional para:

- Ganho de experiência prática
- Compreensão de padrões assíncronos
- Treinamento em escalabilidade
- Integração real com LLM

---

## 🚀 Roadmap

### Fase 1 – Estrutura Base
- Setup do frontend
- Setup da API
- Integração com MongoDB
- Consultas básicas

### Fase 2 – Mensageria
- Setup do RabbitMQ
- Implementação do Producer
- Implementação do Worker
- Persistência assíncrona

### Fase 3 – Dashboard
- Estatísticas básicas
- Queries agregadas
- Insights iniciais

### Fase 4 – IA
- Integração com Microsoft Agent Framework
- Chat de consultas
- Geração de insights

### Fase 5 – Refinamento
- Dockerização
- Testes básicos
- Documentação
- (Opcional) Introdução do Redis

---

## 📊 Escopo Controlado

O projeto não inclui:

- Autenticação
- Controle de permissões
- Pagamentos
- Observabilidade avançada
- Kubernetes
- Arquitetura distribuída complexa

Objetivo é manter foco técnico sem inflar escopo.

---

## 🎓 Aprendizados Esperados

- Arquitetura desacoplada
- Processamento assíncrono
- Integração com mensageria
- Modelagem em MongoDB
- Consumo de APIs externas
- Integração prática com LLM
- Pensamento arquitetural

---

## 🧑‍💻 Autor

Projeto desenvolvido como laboratório prático de engenharia de software.