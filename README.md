# CleanArchitecture-ModularMonolith

🚀 **Clean Architecture & Modular Monolith Project**

## Proje Açıklaması

Bu proje, modern yazılım geliştirme süreçlerine uyumlu olarak tasarlanmış, clean architecture prensiplerine uygun ve tek katmanlı bir Modular Monolith yaklaşımını benimseyen bir projedir.

## Özellikler

- **Clean Architecture**: Kodun sürdürülebilirliğini, test edilebilirliğini ve esnekliğini artırmak amacıyla geliştirilmiştir.
- **Generic Repository Design Pattern Kullanımı**: Birden fazla DbContext ile çalışabilme imkanı sunarak, veri yönetimini ve entegrasyonunu daha verimli hale getirir.
- **Tek Katmanlı Modular Monolith Mimari**: Esnek ve ölçeklenebilir çözümler sunar.

## Kurulum

1. Bu repoyu klonlayın:
    ```bash
    git clone https://github.com/NlabsGlobalArchitecturalApproaches/CleanArchitecture-ModularMonolith.git
    ```
2. Proje dizinine gidin:
    ```bash
    cd CleanArchitecture-ModularMonolith
    ```
3. Gerekli bağımlılıkları yükleyin:
    ```bash
    dotnet restore
    ```
4. Veritabanı migrasyonlarını uygulayın:
    ```bash
    dotnet ef database update
    ```
5. Uygulamayı başlatın:
    ```bash
    dotnet run
    ```

## Kullanım

Proje, clean architecture prensiplerine uygun olarak tasarlanmıştır. Katmanlar arası bağımlılıkları yönetmek ve veri erişim katmanını soyutlamak için Generic Repository Design Pattern kullanır. Bu yapı, farklı DbContext'lerle çalışmayı mümkün kılar ve esnek veri yönetim çözümleri sunar.

## Katkıda Bulunma

Katkılarınızı bekliyoruz! Lütfen aşağıdaki adımları izleyin:

1. Bu repoyu forklayın.
2. Yeni bir dal (branch) oluşturun: `git checkout -b feature/isim`.
3. Değişikliklerinizi yapın ve commit edin: `git commit -am 'Yeni özellik ekledim'`.
4. Dalınıza (branch) push edin: `git push origin feature/isim`.
5. Bir Pull Request açın.

## Lisans

Bu proje MIT Lisansı ile lisanslanmıştır. Daha fazla bilgi için `LICENSE` dosyasına bakın.

## İletişim

Sorularınız veya geri bildirimleriniz için lütfen benimle iletişime geçin:

- **Email**: turkmvc@gmail.com
- **LinkedIn**: https://www.linkedin.com/in/turkmvc/

---

# CleanArchitecture-ModularMonolith

🚀 **Clean Architecture & Modular Monolith Project**

## Project Description

This project is designed to align with modern software development processes, adopting clean architecture principles and a single-tier Modular Monolith approach.

## Features

- **Clean Architecture**: Developed to increase code sustainability, testability, and flexibility.
- **Use of Generic Repository Design Pattern**: Allows working with multiple DbContexts, making data management and integration more efficient.
- **Single-Tier Modular Monolith Architecture**: Provides flexible and scalable solutions.

## Installation

1. Clone this repository:
    ```bash
    git clone https://github.com/NlabsGlobalArchitecturalApproaches/CleanArchitecture-ModularMonolith.git
    ```
2. Navigate to the project directory:
    ```bash
    cd CleanArchitecture-ModularMonolith
    ```
3. Restore the necessary dependencies:
    ```bash
    dotnet restore
    ```
4. Apply database migrations:
    ```bash
    dotnet ef database update
    ```
5. Start the application:
    ```bash
    dotnet run
    ```

## Usage

The project is designed according to clean architecture principles. It uses the Generic Repository Design Pattern to manage dependencies between layers and abstract the data access layer. This structure allows working with multiple DbContexts, providing flexible data management solutions.

## Contributing

We welcome contributions! Please follow these steps:

1. Fork this repository.
2. Create a new branch: `git checkout -b feature/your-feature-name`.
3. Make your changes and commit them: `git commit -am 'Add a new feature'`.
4. Push to the branch: `git push origin feature/your-feature-name`.
5. Open a Pull Request.

## License

This project is licensed under the MIT License. For more information, see the `LICENSE` file.

## Contact

For any questions or feedback, please contact me:

- **Email**: turkmvc@gmail.com
- **LinkedIn**: https://www.linkedin.com/in/turkmvc/
