using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;
using SocialNetwork.DAL.Entities;
using SocialNetwork.DAL.Repositories;
using System.ComponentModel.DataAnnotations;

namespace SocialNetwork.BLL.Services
{
    public class UserService
    {
        IUserRepository userRepository;
        public UserService()
        {
            userRepository = new UserRepository();
        }
        public void Register(UserRegistrationData userRegistrationData)
        {
            #region Проверка входных параметров

            if (string.IsNullOrEmpty(userRegistrationData.FirstName))
                throw new ArgumentNullException("Имя не может быть пустой строкой", nameof(userRegistrationData.FirstName));

            if (string.IsNullOrEmpty(userRegistrationData.LastName))
                throw new ArgumentNullException("Фамилия не может быть пустой строкой", nameof(userRegistrationData.LastName));

            if (string.IsNullOrEmpty(userRegistrationData.Password))
                throw new ArgumentNullException("Пароль не может быть пустой строкой", nameof(userRegistrationData.Password));

            if (string.IsNullOrEmpty(userRegistrationData.Email))
                throw new ArgumentNullException("Email не может быть пустой строкой", nameof(userRegistrationData.Email));

            if (userRegistrationData.Password.Length < 8)
                throw new ArgumentException("Длинна пароля должна быть больше 8 символов", nameof(userRegistrationData.Password));

            if (!new EmailAddressAttribute().IsValid(userRegistrationData.Email))
                throw new ArgumentException("Email должен быть корректного формата", nameof(userRegistrationData.Email));

            if (userRepository.FindByEmail(userRegistrationData.Email) != null)
                throw new ArgumentException("Email уже используется", nameof(userRegistrationData.Email));
            #endregion

            var userEntity = new UserEntity()
            {
                firstname = userRegistrationData.FirstName,
                lastname = userRegistrationData.LastName,
                email = userRegistrationData.Email,
                password = userRegistrationData.Password,
            };

            if (userRepository.Create(userEntity) == 0)
                throw new Exception();
        }

        public User Authenticate(UserAuthentificationData userAuthentificationData)
        {
            var findUserEntity = userRepository.FindByEmail(userAuthentificationData.Email);
            if (findUserEntity is null) throw new UserNotFoundException();

            if (findUserEntity.password != userAuthentificationData.Password)
                throw new WrongPasswordException();

            return ConstructUserModel(findUserEntity);
        }

        public User FindByEmail(string email)
        {
            var findUserEntity = userRepository.FindByEmail(email);
            if (findUserEntity is null)
            {
                throw new UserNotFoundException();
            }
            return ConstructUserModel(findUserEntity);
        }

        public void Update(User user)
        {
            var updatableUserEntity = new UserEntity()
            {
                id = user.Id,
                firstname = user.FirstName,
                lastname = user.LastName,
                email = user.Email,
                password = user.Password,
                photo = user.Photo,
                favorite_movie = user.FavoriteMovie,
                favorite_book = user.FavoriteBook
            };

            if (userRepository.Update(updatableUserEntity) == 0)
                throw new Exception();
        }

        private User ConstructUserModel(UserEntity userEntity)
        {
            return new User(userEntity.id,
                            userEntity.firstname,
                            userEntity.lastname,
                            userEntity.email,
                            userEntity.password,
                            userEntity.photo,
                            userEntity.favorite_movie,
                            userEntity.favorite_book);
        }
    }
}
