﻿namespace More.Windows.Interactivity
{
    using global::Windows.UI.Xaml;
    using System;
    using System.ComponentModel;
    using System.ComponentModel.Design;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Represents an application setting entry in the Settings contract.
    /// </summary>
    [CLSCompliant( false )]
    public class ApplicationSetting : DependencyObject
    {
        /// <summary>
        /// Gets the dependency property of the setting identifier.
        /// </summary>
        /// <value>A <see cref="DependencyProperty"/> object.</value>
        [SuppressMessage( "Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes", Justification = "Dependency properties are immutable." )]
        public static readonly DependencyProperty IdProperty =
            DependencyProperty.Register( nameof( Id ), typeof( string ), typeof( ApplicationSetting ), new PropertyMetadata( (object) null ) );

        /// <summary>
        /// Gets the dependency property of the setting name.
        /// </summary>
        /// <value>A <see cref="DependencyProperty"/> object.</value>
        [SuppressMessage( "Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes", Justification = "Dependency properties are immutable." )]
        public static readonly DependencyProperty NameProperty =
            DependencyProperty.Register( nameof( Name ), typeof( string ), typeof( ApplicationSetting ), new PropertyMetadata( null, OnNamePropertyChanged ) );

        /// <summary>
        /// Gets the dependency property of the view <see cref="Type">type</see> name.
        /// </summary>
        /// <value>A <see cref="DependencyProperty"/> object.</value>
        [SuppressMessage( "Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes", Justification = "Dependency properties are immutable." )]
        public static readonly DependencyProperty ViewTypeNameProperty =
            DependencyProperty.Register( nameof( ViewTypeName ), typeof( string ), typeof( ApplicationSetting ), new PropertyMetadata( null, OnViewTypeNamePropertyChanged ) );

        bool identifierSet;

        /// <summary>
        /// Gets or sets the setting identifier.
        /// </summary>
        /// <value>The setting identifier.</value>
        /// <remarks>If the value is unset, the default value is the <see cref="ViewTypeName">view name</see>.</remarks>
        public string Id
        {
            get => (string) GetValue( IdProperty );
            set
            {
                SetValue( IdProperty, value );
                identifierSet = true;
            }
        }

        /// <summary>
        /// Gets or sets the name of the application setting.
        /// </summary>
        /// <value>The name of the application setting.</value>
        public string Name
        {
            get => (string) GetValue( NameProperty );
            set => SetValue( NameProperty, value );
        }

        /// <summary>
        /// Gets or sets the type name of view associated with the application setting.
        /// </summary>
        /// <value>The view <see cref="Type">type</see> name of the content associated with the application setting.</value>
        public string ViewTypeName
        {
            get => (string) GetValue( ViewTypeNameProperty );
            set => SetValue( ViewTypeNameProperty, value );
        }

        /// <summary>
        /// Gets the type of content associated with the application setting.
        /// </summary>
        /// <value>The view <see cref="Type">type</see> of content associated with the application setting.</value>
        public Type ViewType { get; private set; }

        static void OnNamePropertyChanged( DependencyObject sender, DependencyPropertyChangedEventArgs e )
        {
            var @this = (ApplicationSetting) sender;

            if ( @this.identifierSet )
            {
                return;
            }

            @this.Id = (string) e.NewValue;
            @this.identifierSet = false;
        }

        static void OnViewTypeNamePropertyChanged( DependencyObject sender, DependencyPropertyChangedEventArgs e )
        {
            var @this = (ApplicationSetting) sender;
            var typeName = (string) e.NewValue;

            if ( string.IsNullOrEmpty( typeName ) )
            {
                @this.ViewType = null;
                return;
            }

            if ( ServiceProvider.Current.TryGetService( out ITypeResolutionService service ) )
            {
                @this.ViewType = service.GetType( typeName, true );
            }
            else
            {
                @this.ViewType = Type.GetType( typeName, true );
            }
        }
    }
}